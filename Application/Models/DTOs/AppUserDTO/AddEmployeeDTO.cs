using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.DTOs.AppUserDTO
{
    public class AddEmployeeDTO
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public string CitizenId { get; set; }
        public string? Photo { get; set; }
        public IFormFile? Photos { get; set; }
        public string Profession { get; set; }
        public Gender Gender { get; set; }
        public string BirthPlace { get; set; }       
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public string SelectedCity { get; set; }
        public string SelectedTown { get; set; }
        public string SelectedDistrict { get; set; }
        public string? SelectedQuarter { get; set; }
        public int PostalCode { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public decimal Salary { get; set; } 
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; } = DateTime.Now;      
        public DateTime? CreateTime { get; set; }=DateTime.Now;
        

    }
}
