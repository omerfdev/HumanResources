using Domain.Entities.Abstract;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class CreatePDF : IBase
    {
        public int PdfId { get; set; }
        public int EmployeeId { get; set; }
        public AppUser Employee { get; set; }
        public int SpendingId { get; set; }
        public Spending Spending { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get ; set ; }
        public Status Status { get ; set ; }
        public DateTime? CreateTime { get ; set ; }
        public DateTime? ModifiedTime { get ; set ; }
        public DateTime? DeleteTime { get ; set ; }
        public DateTime? ReplyTime { get ; set ; }
        public DateTime? RequestTime { get ; set ; }
    }
}
