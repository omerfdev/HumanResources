using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using Domain.Entities.Abstract;

namespace Domain.Entities.Concrete
{
    public class SendEmail :IBase
    {
        public int SendEMailId { get; set; }
        public string MailFrom { get; set; }
        public string MailTo { get; set; }
        public string? ResetLink { get; set; }
        public string? ConfirmationLink { get; set; }
        public EmailType EmailType { get; set; }
        public string HtmlTemplateName { get; set; }
        public bool IsActive { get; set; }
        public Status Status { get ; set ; }
        public DateTime? CreateTime { get ; set ; }
        public DateTime? ModifiedTime { get ; set ; }
        public DateTime? DeleteTime { get ; set ; }
        public DateTime? ReplyTime { get ; set ; }
        public DateTime? RequestTime { get ; set ; }
    }
}
