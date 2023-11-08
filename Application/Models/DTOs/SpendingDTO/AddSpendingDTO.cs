using Application.ExtensionValidations;
using Domain.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.DTOs.SpendingDTO
{
    public class AddSpendingDTO
    {     
        public decimal Amount { get; set; }
        public int SpendingTypeID { get; set; }
        public int CurrencyID { get; set; }
        public string CurrencyName { get; set; }
        public List<Currency>? CurrencyNameOptions { get; set; }
        public List<SpendingType>? SpendingTypes { get; set; }
        public SpendingType SpendingType { get; set; }
        public int EmployeeId { get; set; }
        [FileValidation]
        public string? DocumentPath { get; set; }
        [FileValidation]
        public IFormFile? SpendingDocument { get; set; }
        public IFormFile? DocumentFile { get; set; }
    }
}
