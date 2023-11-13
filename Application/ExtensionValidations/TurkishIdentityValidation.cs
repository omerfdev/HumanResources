using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ExtensionValidations
{
    public class TurkishIdentityValidation:ValidationAttribute
    {
        public class TCKCheck : ValidationAttribute
        {
            protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
            {
                string turkishId = (string)value;
                if (turkishId == null)
                {
                    return new ValidationResult("TCK cannot be empty.");
                }
                else if (turkishId.Length != 11)
                {
                    return new ValidationResult("TCK must consist of 11 digits.");
                }
                else if (turkishId[0] == '0')
                {
                    return new ValidationResult("The first digit of TCK cannot be zero.");
                }

                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += int.Parse(turkishId[i].ToString());
                }

                if (sum % 10 != int.Parse(turkishId[10].ToString()))
                {
                    return new ValidationResult("Invalid TCK.");
                }

                bool onlyDigits = true;

                foreach (char c in turkishId)
                {
                    if (!char.IsDigit(c))
                    {
                        onlyDigits = false;
                        break;
                    }
                }
                int digit1 = int.Parse(turkishId[0].ToString());
                int digit2 = int.Parse(turkishId[1].ToString());
                int digit3 = int.Parse(turkishId[2].ToString());
                int digit4 = int.Parse(turkishId[3].ToString());
                int digit5 = int.Parse(turkishId[4].ToString());
                int digit6 = int.Parse(turkishId[5].ToString());
                int digit7 = int.Parse(turkishId[6].ToString());
                int digit8 = int.Parse(turkishId[7].ToString());
                int digit9 = int.Parse(turkishId[8].ToString());
                int digit10 = int.Parse(turkishId[9].ToString());
                int digit11 = int.Parse(turkishId[10].ToString());

                int oddSum = digit1 + digit3 + digit5 + digit7 + digit9;
                int evenSum = digit2 + digit4 + digit6 + digit8+digit10;
                int result = (oddSum * 7 - evenSum) % 10;

                if (result != digit10)
                {
                    return new ValidationResult("Invalid TCK.");
                }

                if (!onlyDigits)
                {
                    return new ValidationResult("Invalid TCK.");
                }

                return ValidationResult.Success;
            }
        }
    }
}
