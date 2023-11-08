using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ExtensionValidations
{
    public class LetterValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string input = value.ToString();
                if (!string.IsNullOrEmpty(input) && !input.All(char.IsLetter))
                {
                    return new ValidationResult(ErrorMessage ?? "Input must contain only letters.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
