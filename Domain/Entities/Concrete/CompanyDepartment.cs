using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class CompanyDepartment
    {
        [Key]
        public int CompanyDepartmentId { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
    }
}
