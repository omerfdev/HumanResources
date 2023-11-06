using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.DTOs.SpendingTypeDTO
{
    public class AddSpendingTypeDTO
    { 
        public string SpendingName { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public bool IsActive { get; set; }
        public Status Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public DateTime? ReplyTime { get; set; }
        public DateTime? RequestTime { get; set; }
    }
}
