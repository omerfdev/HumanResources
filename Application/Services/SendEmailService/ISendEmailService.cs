using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.SendEmailService
{
    public interface ISendEmailService
    { /// <summary>
      /// Send Email for Forget Password
      /// 
      /// You Must Add Controller Add
      /// 
      ///   private readonly IWebHostEnvironment _IWebHostEnvironment;
      /// 
      /// You should look wwwroot foler for EmailTemplate
      /// 
      /// public XController(IWebHostEnvironment IWebHostEnvironment){_IWebHostEnvironment = IWebHostEnvironment;}
      /// 
      /// </summary>     
      /// <param name="mailTO"></param>
      /// <param name="emailType"></param>
      /// <param name="TemplateFolder"></param>
      /// <param name="htmlName"></param>
      /// <param name="user"></param>   
      /// <param name="resetLink"></param>
      /// <param name="replyDate"></param>
      /// <returns></returns>
        Task SendForgetPasswordEmailAsync(string mailTO, EmailType emailType, string TemplateFolder, string htmlName, AppUser user, string resetLink, string replyDate);
        /// <summary>
        /// Send Email for Confirmation Link
        /// 
        /// You Must Add Controller Add
        /// 
        ///   private readonly IWebHostEnvironment _IWebHostEnvironment;
        ///   
        /// public XController(IWebHostEnvironment IWebHostEnvironment){_IWebHostEnvironment = IWebHostEnvironment;}
        /// 
        /// You should look wwwroot foler for EmailTemplate
        /// 
        /// </summary>
         /// <param name="mailTO"></param>
        /// <param name="emailType"></param>
        /// <param name="TemplateFolder"></param>
        /// <param name="htmlName"></param>
        /// <param name="user"></param>
        /// <param name="status"></param>
        /// <param name="confirmationLink"></param>
        /// <returns></returns>
        Task SendConfirmationEmailAsync(string mailTO, EmailType emailType, string TemplateFolder, string htmlName, AppUser user, Status status, string confirmationLink);
        /// <summary>
        /// Send Email for Request Info Status
        /// 
        /// You Must Add Controller Add
        /// 
        ///   private readonly IWebHostEnvironment _IWebHostEnvironment;
        ///   
        /// public XController(IWebHostEnvironment IWebHostEnvironment){_IWebHostEnvironment = IWebHostEnvironment;}
        /// 
        /// 
        /// You should look wwwroot foler for EmailTemplate
        /// 
        /// </summary>
        /// <param name="mailTO"></param>
        /// <param name="emailType"></param>
        /// <param name="TemplateFolder"></param>
        /// <param name="htmlName"></param>
        /// <param name="user"></param>  
        /// <param name="createDate"></param>
        /// <param name="replyDate"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task SendRequestInfoEmailAsync(string mailTO, EmailType emailType, string TemplateFolder, string htmlName, AppUser user,string createDate, string replyDate, Status status);
  
    }
}
