using Application.Models.DTOs.SpendingDTO;
using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.SpendingService
{
    public interface ISpendingService
    {
        Task<int> CreateSpendingRequestAsync(AddSpendingDTO CreateSpendingDTO);
        Task<int> UpdateSpendingAsync(UpdateSpendingDTO UpdateSpendingDTO);       
        Task<List<Spending>> GetAllSpendingAsync(int EmployeeId);
        Task<List<Spending>> GetFilteredSpendingAsync(int employeeId, Status Status);
        Task UploadSpendingDocumentAsync(int spendingId, string documentPath);
        Task<Spending> GetSpendingAsync(int spendingId);
        Task RemoveSpending(int id);
    }
}
