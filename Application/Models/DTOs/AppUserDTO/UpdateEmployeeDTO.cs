using Application.ExtensionValidations;
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
    public class UpdateEmployeeDTO
    {
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string Surname { get; set; }
        public string? SecondSurname { get; set; }
        public string CitizenId { get; set; }
        public string Email { get; set; }
        [EmailValidation]
        public string UserEmail { get; set; }
        [TelephoneNumberValidation]
        public string TelephoneNumber { get; set; }
        public string? Photo { get; set; }
        public IFormFile? Photos { get; set; }
        public string Profession { get; set; }
        public Gender Gender { get; set; }
        public string BirthPlace { get; set; }
        public byte NumberOfDayOff { get; set; }
        public byte RemainingNumberOfDayOff { get; set; }
        public int AppRoleId { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public string SelectedCity { get; set; }
        public string SelectedTown { get; set; }
        public string SelectedDistrict { get; set; }
        public string? SelectedQuarter { get; set; }
        public int PostalCode { get; set; }
        public decimal Salary { get; set; }
        public Status Status { get; set; }
        public bool IsActive { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public DateTime? ReplyTime { get; set; }
        public DateTime? RequestTime { get; set; }
    }
}
