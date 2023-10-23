using Domain.Entities.Abstract;
using Domain.Entities.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class Spending : IBase
    {
        public int SpendingId { get; set; }
        public AppUser Employee { get; set; }
        public int EmployeeId { get; set; }
        public Currency Currency { get; set; }
        public string CurrencyCode { get; set; }
        public SpendingType SpendingType { get; set; }
        public string SpendingTypeId { get; set; }
        public decimal AmountOfSpending { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalSpending { get; set; }
        public Status Status { get; set; } = Status.Pending;
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool IsActive { get ; set ; }
        public DateTime? ReplyTime { get ; set ; }
        public DateTime? RequestTime { get ; set ; }
    }
}
