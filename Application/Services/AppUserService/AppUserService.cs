using Application.Models.DTOs.AppUserDTO;
using Application.Models.VMs.AppUserDTO;
using AutoMapper;
using Domain.Entities.Concrete;
using Domain.Repositories;
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
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AppUserService(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IAppUserRepository userRepository, IMapper mapper)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<int> AddEmployeeAsync(AddEmployeeDTO addemployeeDTO)
        {
            
        }

        public async Task<List<AppUser>> GetAllActiveUsersByCompanyIdAsync(int companyId)
        {
            return _userRepository.GetAll().Where(x => x.IsActive == true && x.CompanyId == companyId).ToList();
        }
        public async Task<List<AppUser>> GetAllPassiveUsersByCompanyIdAsync(int companyId)
        {
            return _userRepository.GetAll().Where(x => x.IsActive == false && x.CompanyId == companyId).ToList();
        }

        public async Task<List<AppUser>> GetDayOffRequestsWithUserAsync(int id)
        {
            return await _userRepository.GetAllAsync(x => x.DayOffAppUser.AppUserId == id);
        }

        public async Task<AppUser> GetUserAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<AppUser> GetUserByEmailAsync(string email)
        {
            return await _userRepository.GetFirstOrDefaultAsync(x => x.Email == email);
        }

        public Task<AppUser> GetUserWithEmailAsync(ForgetPasswordVM forgetPasswordVM)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserWithEmailAsync(CreatePasswordVM createPasswordVM)
        {
            throw new NotImplementedException();
        }

        public async Task<AppUser> GetUserWithCitizenIdAsync(string citizenId)
        {
            return await _userRepository.GetFirstOrDefaultAsync(x => x.CitizenId == citizenId);
        }

        public async Task<SignInResult> LoginAsync(AppUserLoginDTO appUserLoginDTO)
        {
            AppUser user = await _userRepository.GetFirstOrDefaultAsync(x => x.Email == appUserLoginDTO.Email);
            await _signInManager.SignOutAsync();
            return await _signInManager.PasswordSignInAsync(user, appUserLoginDTO.Password, false, false);
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public Task<int> UpdateEmployeeAsync(UpdateEmployeeDTO updateemployeeDTO)
        {
            throw new NotImplementedException();
        }


    }
}
