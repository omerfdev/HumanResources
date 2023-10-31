using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.SpendingTypeService
{
    public interface ISpendingTypeService
    {
        Task CreateSpendingTypeAsync(SpendingType spendingType);
        Task UpdateSpendingTypeAsync(SpendingType spendingType);
        Task DeleteSpendingTypeAsync(int spendingTypeId);
        Task<List<SpendingType>> GetAllSpendingTypesAsync();        
        Task<SpendingType> GetSpendingTypeAsync(int spendingTypeId);
    }
}
