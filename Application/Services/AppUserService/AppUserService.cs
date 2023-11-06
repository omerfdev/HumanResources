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
        private readonly IAppUserService _appUserService;

        public AppUserService(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IAppUserRepository userRepository, IMapper mapper, IAppUserService appUserService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userRepository = userRepository;
            _mapper = mapper;
            _appUserService = appUserService;
        }
        public async Task<int> AddEmployeeAsync(AddEmployeeDTO addemployeeDTO)
        {
            AppUser user = _mapper.Map<AppUser>(addemployeeDTO);
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.Email = await _appUserService.CreateEmailAsync(user.FirstName, user.Surname, user.Company.CompanyName);
            user.UserName = user.Email;
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.NormalizedEmail;
            await _userRepository.AddAsync(user);
            //user.AppRoleId = addemployeeDTO.RoleId;
            //await _userManager.AddToRoleAsync(user,addemployeeDTO.Role);
            user.AddressId = user.Address.AddressId;
            return await _userRepository.UpdateAsync(user);
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

        public async Task<AppUser> GetUserWithEmailAsync(ForgetPasswordVM forgetPasswordVM)
        {
           return await _userRepository.GetFirstOrDefaultAsync(x=>x.Email == forgetPasswordVM.Email);
        }

        public async Task<AppUser> GetUserWithEmailAsync(CreatePasswordVM createPasswordVM)
        {
            return await _userRepository.GetFirstOrDefaultAsync(x => x.Id == createPasswordVM.UserId);
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

        public async Task<int> UpdateEmployeeAsync(UpdateEmployeeDTO updateemployeeDTO)
        {
            AppUser user = await _userRepository.GetFirstOrDefaultAsync(x => x.Email == updateemployeeDTO.Email);
            _mapper.Map(user, updateemployeeDTO);
            return await _userRepository.UpdateAsync(user);
        }

        public async Task<string> CreateEmailAsync(string firstName, string lastName, string companyName)
        {
            string email = $"{_appUserService.ConvertCharAsync(firstName)}.{_appUserService.ConvertCharAsync(lastName)}@{_appUserService.ConvertCharAsync(companyName)}.com";
            return email;
        }

        public async Task<string> ConvertCharAsync(string text)
        {
            text = text.Replace("Ç", "C").Replace("ç", "c")
                        .Replace("İ", "I").Replace("ı", "i")
                        .Replace("Ğ", "G").Replace("ğ", "g")
                        .Replace("Ö", "O").Replace("ö", "o")
                        .Replace("Ş", "S").Replace("ş", "s")
                        .Replace("Ü", "U").Replace("ü", "u");
            return text;
        }
    }
}
