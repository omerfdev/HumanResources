using Application.Models.DTOs.AppUserDTO;
using Application.Models.VMs.AppUserDTO;
using Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.AppUserService
{
    public interface IAppUserService
    {
        Task<string> CreateEmailAsync(string firstName,string lastName,string companyName);
        Task<string> ConvertCharAsync(string text);
        Task LogoutAsync();
        Task<SignInResult> LoginAsync(AppUserLoginDTO appUserLoginDTO);
        Task<AppUser> GetUserWithCitizenIdAsync(string citizenId);
        Task<List<AppUser>> GetDayOffRequestsWithUserAsync(int id);
        Task<AppUser> GetUserAsync(int id);
        Task<AppUser> GetUserWithEmailAsync(ForgetPasswordVM forgetPasswordVM);
        Task<AppUser> GetUserWithEmailAsync(CreatePasswordVM createPasswordVM);
        Task<List<AppUser>> GetAllActiveUsersByCompanyIdAsync(int companyId);
        Task<List<AppUser>> GetAllPassiveUsersByCompanyIdAsync(int companyId);
        Task<AppUser> GetUserByEmailAsync(string email);
        Task<int> AddEmployeeAsync(AddEmployeeDTO addemployeeDTO);
        Task<int> UpdateEmployeeAsync(UpdateEmployeeDTO updateemployeeDTO);


    }
}
