using Application.Models.DTOs.CompanyDTO;
using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CreatePDFService
{
    public interface ICreatePDFService
    {
        Task<CreatePDF> GetPDFAsync(int createPdfId);
        Task<byte[]> AddPDFAsync(CreatePDF createPDF,AppUser user,int spendingId);
        Task<List<CreatePDF>> GetActivePDFAsync();
        //Task<List<CreatePDF>> GetCompanyAsync(Expression<Func<CreatePDF, bool>> predicate, params Expression<Func<CreatePDF, object>>[] includes);
        //Task<int> UpdatePDFAsync(CreatePDF updatePDF);
        Task<int> DeletePDFAsync(int createPdfId);
    }
}
