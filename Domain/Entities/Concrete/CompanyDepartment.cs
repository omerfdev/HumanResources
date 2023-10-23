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
        public bool IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Status Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? CreateTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? ModifiedTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeleteTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? ReplyTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? RequestTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
