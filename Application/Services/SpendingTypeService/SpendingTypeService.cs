using Application.Services.SpendingService;
using Domain.Entities.Concrete;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.SpendingTypeService
{
    public class SpendingTypeService : ISpendingTypeService
    {
        private readonly ISpendingTypeRepository _spendingTypeRepository;
        public SpendingTypeService(ISpendingTypeRepository spendingTypeRepository)
        {
            _spendingTypeRepository = spendingTypeRepository;
        }
        public async Task CreateSpendingTypeAsync(SpendingType spendingType)
        {
            await _spendingTypeRepository.AddAsync(spendingType);
        }

        public async Task DeleteSpendingTypeAsync(int spendingTypeId)
        {
            await _spendingTypeRepository.DeactivateAsync(spendingTypeId);
        }

        public async Task<List<SpendingType>> GetAllSpendingTypesAsync()
        {
            return await _spendingTypeRepository.GetAllAsync(x=>x.IsActive==true);  
        }

        public async Task<SpendingType> GetSpendingTypeAsync(int spendingTypeId)
        {
           return await _spendingTypeRepository.GetByIdAsync(spendingTypeId);
        }

        public async Task UpdateSpendingTypeAsync(SpendingType spendingType)
        {
            await _spendingTypeRepository.UpdateAsync(spendingType);
        }
    }
}
