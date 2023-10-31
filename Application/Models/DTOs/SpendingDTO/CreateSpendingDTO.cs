using Domain.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.DTOs.SpendingDTO
{
    public class CreateSpendingDTO
    {
        public decimal Amount { get; set; }
        public int SpendingTypeID { get; set; }
        public string CurrencyName { get; set; }
        public List<Currency> CurrencyNameOptions { get; set; }
        public List<SpendingType> SpendingTypes { get; set; }
        public SpendingType ExpenseType { get; set; }
        public int EmployeeId { get; set; }
        public string DocumentPath { get; set; }
        public IFormFile DocumentFile { get; set; }
        public CreateSpendingDTO()
        {
            CurrencyNameOptions = new List<Currency>();
            SpendingTypes = new List<SpendingType>();
        }
    }
}
