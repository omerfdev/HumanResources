using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.DayOffService
{
    public class DayOffService : IDayOffService
    {
        private readonly IDayOffRepository _dayoffRepository;
        private readonly UserManager<AppUser> _userManager;

        public DayOffService(IDayOffRepository dayoffRepository, UserManager<AppUser> userManager)
        {
            _dayoffRepository = dayoffRepository;
            _userManager = userManager;
        }
        public async Task CreateDayOffAsync(DayOff dayOff)
        {
            await _dayoffRepository.AddAsync(dayOff);
        }

        public async Task<List<DayOff>> GetDayOffAsync()
        {
            return await _dayoffRepository.GetAllAsync(x=>x.IsActive==true);
        }

        public async Task<DayOff> GetDayOffAsync(int DayOffId)
        {
            return await _dayoffRepository.GetByIdAsync(DayOffId);
        }

        public async Task<List<DayOff>> GetDayOffByStatusAsync(Status Status, int id)
        {
            var dayoff=await _dayoffRepository.GetAllAsync(x=> x.IsActive==true);
            return dayoff.Where(x=>x.Status==Status && x.EmployeeId==id).ToList();
        }

        public async Task<List<DayOff>> GetDayOffByStatusAsync(Status Status, int id, params Expression<Func<DayOff, object>>[] includes)
        {
           var dayoff=await _dayoffRepository.GetAllAsync(x=> x.IsActive==true,p=>p.DayOffType);
            return dayoff.Where(p=>p.Status==Status&&p.EmployeeId==id).ToList();
        }

        public async Task RemoveDayOffAsync(int id)
        {
            await _dayoffRepository.DeactivateAsync(id);  
        }
    }
}
