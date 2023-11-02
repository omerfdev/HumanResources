using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Enum
{
    public enum EmailType
    {
        [Display(Name = "Forget Password")]
        ForgetPassword,
        [Display(Name = "Confirmation Email")]
        ConfirmationEmail,
        [Display(Name = "Request Info Email")]
        RequestInfoEmail,
    }
}
