using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ExtensionValidations
{
    public class FileValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            IFormFile file = value as IFormFile;
            if (file != null)
            {
                string[] fileExtensions = { ".jpg", ".jpeg", ".png", ".pdf" };
                var fileExtension = Path.GetExtension(file.FileName);
                var result = fileExtensions.Any(x => x.EndsWith(file.FileName));
                if (!result) return new ValidationResult(".jpg, .jpeg, .png,.pdf format is correct");
            }
            return ValidationResult.Success;
        }
    }
}
