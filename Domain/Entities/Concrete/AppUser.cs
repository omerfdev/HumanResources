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
        public string Photo { get; set; }
        public string Profession { get; set; }      
        public Gender Gender { get; set; }             
        public string BirthPlace { get; set; }
        public byte NumberOfDayOff { get; set; }
        public byte RemainingNumberOfDayOff { get; set; }
        public bool MarriageStatus { get; set; }
        public int AppRoleId { get; set; }        
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<Spending>? Spendings { get; set; }
        public ICollection<DayOffAppUser>? DayOffAppUser { get; set; }
        public decimal Salary { get; set; }
        public Status Status { get; set; }
        public bool IsActive { get ; set ; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public DateTime? CreateTime { get ; set ; }
        public DateTime? ModifiedTime { get; set ; }
        public DateTime? DeleteTime { get ; set ; }
        public DateTime? ReplyTime { get ; set ; }
        public DateTime? RequestTime { get; set ; }

        public AppUser()
        {
            int currentYear = DateTime.Now.Year;
            int hireYear = HireDate.Value.Year;
            int yearsOfWork = currentYear - hireYear;

            if (yearsOfWork >= 0 && yearsOfWork <= 6)
            {
                NumberOfDayOff = 14;
            }
            else if (yearsOfWork > 6)
            {
                NumberOfDayOff = 20;
            }
            else
            {

                NumberOfDayOff = 0;
            }
        }
    }
}
