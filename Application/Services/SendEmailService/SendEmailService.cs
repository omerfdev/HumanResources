using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using System.Net.Mail;
using System.Net;
using MimeKit;

namespace Application.Services.SendEmailService
{
    public class SendEmailService : ISendEmailService
    {
       
        public async Task SendConfirmationEmailAsync(string mailTO, EmailType emailType, string TemplateFolder, string htmlName, AppUser user,Status status, string confirmationLink)
        {
            string _IWebHostEnvironment = "_IWebHostEnvironment.WebRootPath";
            string HtmlBody = "";
            var PathToFile = Path.Combine(_IWebHostEnvironment, TemplateFolder, htmlName);

            var builder = new BodyBuilder();
            using (StreamReader sr = System.IO.File.OpenText(PathToFile))
            {
                builder.HtmlBody = sr.ReadToEnd();
            }

            builder.HtmlBody = builder.HtmlBody.Replace("{0}", user.FirstName);
            builder.HtmlBody = builder.HtmlBody.Replace("{1}", status.ToString());
            builder.HtmlBody = builder.HtmlBody.Replace("{2}", confirmationLink);

            MailMessage mail = new MailMessage();
            mail.To.Add(user.Email);
            mail.From = new MailAddress("noreplyhrelp@gmail.com");
            mail.Subject = emailType.ToString();
            mail.Body = builder.HtmlBody;
            mail.IsBodyHtml = true;

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                ServicePointManager.ServerCertificateValidationCallback = (s, certificate, chain, sslPolicyErrors) => true;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("noreplyhrelp@gmail.com", "rmzqiazgoktnbcac");
                 smtp.Send(mail); 
            }
     
        }

        public async Task SendForgetPasswordEmailAsync(string mailTO, EmailType emailType, string TemplateFolder, string htmlName, AppUser user, string resetLink, string replyDate)
        {
            string _IWebHostEnvironment = "_IWebHostEnvironment.WebRootPath";
            string HtmlBody = "";
            var PathToFile = Path.Combine(_IWebHostEnvironment, TemplateFolder, htmlName);

            var builder = new BodyBuilder();
            using (StreamReader sr = System.IO.File.OpenText(PathToFile))
            {
                builder.HtmlBody = sr.ReadToEnd();
            }

            builder.HtmlBody = builder.HtmlBody.Replace("{0}", user.FirstName);
            builder.HtmlBody = builder.HtmlBody.Replace("{1}", replyDate);
            builder.HtmlBody = builder.HtmlBody.Replace("{2}", resetLink);

            MailMessage mail = new MailMessage();
            mail.To.Add(user.Email);
            mail.From = new MailAddress("noreplyhrelp@gmail.com");
            mail.Subject = emailType.ToString();
            mail.Body = builder.HtmlBody;
            mail.IsBodyHtml = true;

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                ServicePointManager.ServerCertificateValidationCallback = (s, certificate, chain, sslPolicyErrors) => true;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("noreplyhrelp@gmail.com", "rmzqiazgoktnbcac");
                smtp.Send(mail);
            }
   
        }

        public async Task SendRequestInfoEmailAsync(string mailTO, EmailType emailType, string TemplateFolder, string htmlName, AppUser user,string createDate, string replyDate, Status status)
        {
            string _IWebHostEnvironment = "_IWebHostEnvironment.WebRootPath";
            string HtmlBody = "";
            var PathToFile = Path.Combine(_IWebHostEnvironment, TemplateFolder, htmlName);

            var builder = new BodyBuilder();
            using (StreamReader sr = System.IO.File.OpenText(PathToFile))
            {
                builder.HtmlBody = sr.ReadToEnd();
            }

            builder.HtmlBody = builder.HtmlBody.Replace("{0}", user.FirstName);
            builder.HtmlBody = builder.HtmlBody.Replace("{1}", createDate);
            builder.HtmlBody = builder.HtmlBody.Replace("{2}", replyDate);
            builder.HtmlBody = builder.HtmlBody.Replace("{3}", status.ToString());

            MailMessage mail = new MailMessage();
            mail.To.Add(user.Email);
            mail.From = new MailAddress("noreplyhrelp@gmail.com");
            mail.Subject = emailType.ToString();
            mail.Body = builder.HtmlBody;
            mail.IsBodyHtml = true;

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                ServicePointManager.ServerCertificateValidationCallback = (s, certificate, chain, sslPolicyErrors) => true;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("noreplyhrelp@gmail.com", "rmzqiazgoktnbcac");
                smtp.Send(mail);
           
            }
           
        }
    }
}
