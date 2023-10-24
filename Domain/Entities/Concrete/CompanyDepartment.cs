using Domain.Entities.Abstract;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class CompanyDepartment:IBase
    {
        [Key]
        public int CompanyDepartmentId { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public bool IsActive { get ; set; }
        public Status Status { get ; set ; }
        public DateTime? CreateTime { get ; set ; }
        public DateTime? ModifiedTime { get; set ; }
        public DateTime? DeleteTime { get; set; }
        public DateTime? ReplyTime { get ; set ; }
        public DateTime? RequestTime { get ; set; }
    }
}
