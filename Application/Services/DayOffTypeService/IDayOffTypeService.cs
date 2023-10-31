using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.DayOffTypeService
{
    public interface IDayOffTypeService
    {
        Task<DayOffType> GetDayOffTypeAsync(int dayTypeId);
        Task<DayOffType> GetDayOffTypeByNameAsync(string name);
        Task CreateDayOffTypeAsync(DayOffType leaveType);
        Task<List<DayOffType>> GetAllDayOffTypesAsync();
    }
}
