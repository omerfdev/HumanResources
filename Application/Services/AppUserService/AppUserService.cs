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
    public class AppUserService : IAppUserService
    {
        public Task<int> AddEmployeeAsync(AddEmployeeDTO addemployeeDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<AppUser>> GetAllUsersByCompanyIdAsync(int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AppUser>> GetAllUsersByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetRequestsWithUserAndCompanyAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserWithEmailAsync(ForgetPasswordVM forgetPasswordVM)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserWithEmailAsync(CreatePasswordVM createPasswordVM)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserWithIdentityAsync(string identity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsEmailInUser(string email)
        {
            throw new NotImplementedException();
        }

        public Task<SignInResult> LoginAsync(AppUserLoginDTO appUserLoginDTO)
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEmployeeAsync(UpdateEmployeeDTO updateemployeeDTO)
        {
            throw new NotImplementedException();
        }
    }
}
