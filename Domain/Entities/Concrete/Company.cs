using Domain.Entities.Abstract;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class Company : IBase
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public decimal Budget { get; set; }
        public int ManagerId { get; set; }
        public AppUser Manager { get; set; }
        public ICollection<AppUser> Employees { get; set; }
        public ICollection<Department> Departments { get; set; }
        public Status Status { get; set; }
    }
}
