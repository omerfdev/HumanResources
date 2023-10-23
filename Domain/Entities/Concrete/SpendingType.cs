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
    public class SpendingType:IBase
    {
        public int SpendingId { get; set; }
        public string SpendinggName { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public ICollection<Spending>? Spending { get; set; }
        public bool IsActive { get; set ; }
        public Status Status { get ; set ; }
        public DateTime? CreateTime { get ; set ; }
        public DateTime? ModifiedTime { get ; set ; }
        public DateTime? DeleteTime { get ; set ; }
        public DateTime? ReplyTime { get ; set ; }
        public DateTime? RequestTime { get ; set ; }
    }
}
