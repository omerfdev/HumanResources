using Application.ExtensionValidations;
using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.DTOs.AppUserDTO
{
    public class AddEmployeeDTO
    {
        [Required]
        [LetterValidation]
        public string FirstName { get; set; }
        
        [LetterValidation]
        public string SecondName { get; set; }
        [Required]
        [LetterValidation]
        public string Surname { get; set; }
        
        [LetterValidation]
        public string SecondSurname { get; set; }
        [NumberValidation]
        public string CitizenId { get; set; }
        [ImageValidation]
        public string? Photo { get; set; }
        [ImageValidation]
        public IFormFile? Photos { get; set; }
        public string Profession { get; set; }
        public Gender Gender { get; set; }
        public string BirthPlace { get; set; }
        [Required(ErrorMessage ="You should give your email adress")]
        [EmailValidation]
        public string UserEmail { get; set; }
        [TelephoneNumberValidation]
        public string TelephoneNumber { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public string SelectedCity { get; set; }
        public string SelectedTown { get; set; }
        public string SelectedDistrict { get; set; }
        public string? SelectedQuarter { get; set; }
        [NumberValidation]
        public int PostalCode { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
        public AppRole RoleName { get; set; }
        public decimal Salary { get; set; } 
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; } = DateTime.Now;      
        public DateTime? CreateTime { get; set; }=DateTime.Now;
        

    }
}
