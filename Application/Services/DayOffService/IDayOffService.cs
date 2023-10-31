using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.DayOffService
{
    public interface IDayOffService
    {
        Task CreateDayOffAsync(DayOff dayOff);
        Task<List<DayOff>> GetDayOffAsync();
        Task<DayOff> GetDayOffAsync(int DayOffId);
        Task<List<DayOff>> GetDayOffByStatusAsync(Status Status, int id);
        Task<List<DayOff>> GetDayOffByStatusAsync(Status Status, int id, params Expression<Func<DayOff, object>>[] includes);
        Task RemoveDayOffAsync(int id);
    }
}
