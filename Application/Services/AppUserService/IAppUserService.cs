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
        Task Logout();
        Task<SignInResult> LoginAsync(AppUserLoginDTO appUserLoginDTO);
        Task<bool> IsEmailInUser(string email);
        Task<AppUser> GetUserWithIdentityAsync(string identity);
        Task<AppUser> GetRequestsWithUserAndCompanyAsync(int id);
        Task<AppUser> GetUserAsync(int id);        
        Task<AppUser> GetUserWithEmailAsync(ForgetPasswordVM forgetPasswordVM);
        Task<AppUser> GetUserWithEmailAsync(CreatePasswordVM createPasswordVM);
        Task<List<AppUser>> GetAllUsersByCompanyIdAsync(int companyId);
        Task<List<AppUser>> GetAllUsersByEmailAsync(string email);
        Task<int> AddEmployeeAsync(AddEmployeeDTO addemployeeDTO);
        Task<int> UpdateEmployeeAsync(UpdateEmployeeDTO updateemployeeDTO);      


    }
}
