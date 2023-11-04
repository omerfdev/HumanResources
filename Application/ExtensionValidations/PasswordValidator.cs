using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ExtensionValidations
{
    public class PasswordValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is string password)
            {
                if (password.Length < 8)
                {
                    throw new ValidationException("Password should be at least 8 characters long.");
                }

                if (!password.Any(char.IsUpper))
                {
                    throw new ValidationException("Password should contain at least one uppercase letter.");
                }

                if (!password.Any(char.IsLower))
                {
                    throw new ValidationException("Password should contain at least one lowercase letter.");
                }

                if (!password.Any(c => c == '.' || c == '_' || c == '-'))
                {
                    throw new ValidationException("Password should contain at least one of the following characters: '.', '_', or '-'.");
                }

                return true;
            }

            throw new ValidationException("Invalid password value.");
        }
    }
}
