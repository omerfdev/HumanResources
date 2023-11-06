using Application.Models.DTOs.SpendingDTO;
using AutoMapper;
using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.SpendingService
{
    public class SpendingService : ISpendingService
    {
        private readonly IAppUserRepository _appuserRepository;
        private readonly ISpendingRepository _spendingRepository;
        private readonly IMapper _mapper;

        public SpendingService(ISpendingRepository spendingRepository, IMapper mapper, IAppUserRepository appuserRepository)
        {
            _spendingRepository = spendingRepository;
            _mapper = mapper;
            _appuserRepository = appuserRepository;
        }

        public async Task<int> CreateSpendingRequestAsync(AddSpendingDTO spendings)
        {
            Spending spending = new Spending(); 
            _mapper.Map(spendings, spending);
            await _spendingRepository.AddAsync(spending);
            return await _spendingRepository.UpdateAsync(spending);
        }

        public async Task<List<Spending>> GetAllSpendingAsync(int EmployeeId)
        {
            return await _spendingRepository.GetAllAsync(x=> x.EmployeeId == EmployeeId && x.IsActive==true);   
        }

        public async Task<List<Spending>> GetFilteredSpendingAsync(int employeeId, Status Status)
        {
            return await _spendingRepository.GetAllAsync(x => x.EmployeeId == employeeId && x.Status == Status && x.IsActive == true);
        }

        public async Task<Spending> GetSpendingAsync(int spendingId)
        {
            return await _spendingRepository.GetByIdAsync(spendingId);
        }

        public async Task RemoveSpending(int id)
        {
            await _spendingRepository.DeactivateAsync(id);
        }

        public async Task<int> UpdateSpendingAsync(UpdateSpendingDTO UpdateSpendingDTO)
        {
            Spending spending = await _spendingRepository.GetFirstOrDefaultAsync(x => x.SpendingId == UpdateSpendingDTO.SpendingId);
            _mapper.Map(spending, UpdateSpendingDTO);
            return await _spendingRepository.UpdateAsync(spending);
        }

        public async Task UploadSpendingDocumentAsync(int spendingId, string documentPath)
        {
            var spending = await _spendingRepository.GetByIdAsync(spendingId);
            if (spending != null)
            {
                spending.DocumentPath = documentPath;
                await _spendingRepository.UpdateAsync(spending);
            }
        }
    }
}
