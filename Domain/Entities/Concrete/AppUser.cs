using Domain.Entities.Abstract;
using Domain.Entities.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class AppUser :IdentityUser<int>,IBase
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public string CitizenId { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime DismissalDate { get; set; }
        public string BirthPlace { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public decimal Salary { get; set; }
        public Status Status { get; set; }
    }
}
