using Domain.Entities.Abstract;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class Currency : IBase
    {
        [Key]
        public int CurrencyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public byte ExchangeRate { get; set; }
        public ICollection<Spending> Spending { get; set; }
        public bool IsActive { get; set ; }
        public Status Status { get ; set ; }
        public DateTime? CreateTime { get ; set ; }
        public DateTime? ModifiedTime { get ; set; }
        public DateTime? DeleteTime { get ; set ; }
        public DateTime? ReplyTime { get ; set ; }
        public DateTime? RequestTime { get ; set ; }
    }
}
