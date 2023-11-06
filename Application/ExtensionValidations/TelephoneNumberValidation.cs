using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ExtensionValidations
{
   
    public class TelephoneNumberValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is string telephoneNumber)
            {
                string numericPhoneNumber = new string(telephoneNumber.Where(char.IsDigit).ToArray());
                if (numericPhoneNumber.Length == 10)
                {
                    return true;
                }
                else
                {
                    throw new ValidationException("Telephone number must consist of 10 digits.");
                }
            }

            throw new ValidationException("Invalid value for telephone number.");
        }
    }

}
