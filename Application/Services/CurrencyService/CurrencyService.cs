using Domain.Entities.Concrete;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CurrencyService
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }
        public async Task CreateCurrencyAsync(Currency currency)
        {
            await _currencyRepository.AddAsync(currency);
        }

        public async Task<List<Currency>> GetAllCurrencyAsync()
        {
            return await _currencyRepository.GetAllAsync(x => x.IsActive == true);
        }

        public async Task<Currency> GetCurrencyAsync(string currencyName)
        {
            return await _currencyRepository.GetByNameAsync(currencyName);
        }
    }
}
