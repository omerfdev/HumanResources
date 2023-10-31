using Domain.Entities.Concrete;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.DayOffTypeService
{
    public class DayOffTypeService : IDayOffTypeService
    {
        private readonly IDayOffTypeRepository _IDayOffTypeRepository;
        public DayOffTypeService(IDayOffTypeRepository dayoffTypeRepository)
        {
            _IDayOffTypeRepository = dayoffTypeRepository;
        }
        public async Task CreateDayOffTypeAsync(DayOffType dayoffType)
        {
            await _IDayOffTypeRepository.AddAsync(dayoffType);
        }

        public async Task<List<DayOffType>> GetAllDayOffTypesAsync()
        {
            return await _IDayOffTypeRepository.GetAllAsync(x => x.IsActive == true);
        }

        public async Task<DayOffType> GetDayOffTypeAsync(int dayOffTypeId)
        {
            return await _IDayOffTypeRepository.GetByIdAsync(dayOffTypeId);
        }

        public async Task<DayOffType> GetDayOffTypeByNameAsync(string name)
        {
            return await _IDayOffTypeRepository.GetFirstOrDefaultAsync(p => p.DayOffTypeName == name);
        }
    }
}
