using Application.Models.DTOs.SpendingTypeDTO;
using Application.Services.SpendingService;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public SpendingTypeService(ISpendingTypeRepository spendingTypeRepository, IMapper mapper)
        {
            _spendingTypeRepository = spendingTypeRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateSpendingTypeAsync(AddSpendingTypeDTO addSpendingTypeDTO)
        {
            SpendingType spendingType = _mapper.Map<SpendingType>(addSpendingTypeDTO);
            spendingType.CreateTime = DateTime.Now;
            await _spendingTypeRepository.AddAsync(spendingType);
            return await _spendingTypeRepository.UpdateAsync(spendingType);
        }

        public async Task DeleteSpendingTypeAsync(int spendingTypeId)
        {
            await _spendingTypeRepository.DeactivateAsync(spendingTypeId);
        }

        public async Task<List<SpendingType>> GetAllSpendingTypesAsync()
        {
            return await _spendingTypeRepository.GetAllAsync(x => x.IsActive == true);
        }

        public async Task<SpendingType> GetSpendingTypeAsync(int spendingTypeId)
        {
            return await _spendingTypeRepository.GetByIdAsync(spendingTypeId);
        }

        public async Task<int> UpdateSpendingTypeAsync(UpdateSpendingTypeDTO updateSpendingTypeDTO)
        {
           SpendingType spendingType=await _spendingTypeRepository.GetFirstOrDefaultAsync(x=>x.SpendingTypeId==updateSpendingTypeDTO.SpendingTypeId);
            _mapper.Map(spendingType, updateSpendingTypeDTO);
            return await _spendingTypeRepository.UpdateAsync(spendingType);
        }
    }
}
