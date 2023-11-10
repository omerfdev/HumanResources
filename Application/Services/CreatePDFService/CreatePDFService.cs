using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using Domain.Repositories;
using MimeKit;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CreatePDFService
{
    public class CreatePDFService : ICreatePDFService
    {
        private readonly ICreatePDFRepository _createPDFRepository;
        private readonly ISpendingRepository _spendingRepository;

        public CreatePDFService(ICreatePDFRepository createPDFRepository, ISpendingRepository spendingRepository)
        {
            _createPDFRepository = createPDFRepository;
            _spendingRepository = spendingRepository;
        }

        public async Task<byte[]> AddPDFAsync(CreatePDF createPDF,int spendingId,AppUser user)
        {
            var spending= _spendingRepository.GetByIdAsync(spendingId);
            HtmlToPdf htmlToPdf = new HtmlToPdf();
            htmlToPdf.Options.PdfPageSize = PdfPageSize.A4;
            htmlToPdf.Options.PdfPageOrientation= PdfPageOrientation.Portrait;
            htmlToPdf.Options.MarginTop= 20;
            htmlToPdf.Options.MarginRight= 10;
            htmlToPdf.Options.MarginBottom= 20;
            htmlToPdf.Options.MarginLeft= 10;
            string _IWebHostEnvironment = "_IWebHostEnvironment.WebRootPath";
            string HtmlBody = "";
            var PathToFile = Path.Combine(_IWebHostEnvironment, "PDFTemplate", "PDFTemplate.html");
            var builder = new BodyBuilder();
            using (StreamReader sr = System.IO.File.OpenText(PathToFile))
            {
                builder.HtmlBody = sr.ReadToEnd();
            }

            builder.HtmlBody = builder.HtmlBody.Replace("{0}",spending.Result.SpendingId.ToString());
            builder.HtmlBody = builder.HtmlBody.Replace("{1}",spending.Result.CreateTime.ToString());
            builder.HtmlBody = builder.HtmlBody.Replace("{2}",spending.Result.ReplyTime.ToString());
            builder.HtmlBody = builder.HtmlBody.Replace("{3}",spending.Result.SpendingId.ToString());
            builder.HtmlBody = builder.HtmlBody.Replace("{4}",spending.Result.SpendingType.SpendingName);
            builder.HtmlBody = builder.HtmlBody.Replace("{5}",spending.Result.AmountOfSpending.ToString());
            builder.HtmlBody = builder.HtmlBody.Replace("{6}",spending.Result.SpendingType.SpendingName);
            builder.HtmlBody = builder.HtmlBody.Replace("{7}",spending.Result.Currency.Name);
            builder.HtmlBody = builder.HtmlBody.Replace("{8}",spending.Result.TotalSpending.ToString());
            builder.HtmlBody = builder.HtmlBody.Replace("{9}", spending.Result.DocumentPath);
            builder.HtmlBody = builder.HtmlBody.Replace("{10}",spending.Status.ToString());
            builder.HtmlBody = builder.HtmlBody.Replace("{11}",user.FirstName+" "+user.Surname);
            var document = htmlToPdf.ConvertHtmlString(builder.HtmlBody);
            return document.Save();
        }

        public async Task<int> DeletePDFAsync(int createPdfId)
        {
            return await _createPDFRepository.DeactivateAsync(createPdfId);
        }

        public async Task<List<CreatePDF>> GetActivePDFAsync()
        {
            return await _createPDFRepository.GetAllAsync(x=>x.IsActive==true);
        }

        public async Task<CreatePDF> GetPDFAsync(int createPdfId)
        {
            return await _createPDFRepository.GetByIdAsync(createPdfId);
        }
    }
}
