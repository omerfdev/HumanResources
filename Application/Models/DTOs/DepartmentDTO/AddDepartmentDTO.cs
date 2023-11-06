using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.DTOs.DepartmentDTO
{
    public class AddDepartmentDTO
    {       
        public byte CompanyId { get; set; }
        public Company Company { get; set; }
        public AppUser Employee { get; set; }
        public ICollection<AppUser>? Employees { get; set; }
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; }
        public Status Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public DateTime? ReplyTime { get; set; }
        public DateTime? RequestTime { get; set; }
    }
}
