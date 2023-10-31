using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CurrencyService
{
    public interface ICurrencyService
    {
        Task CreateCurrencyAsync(Currency currency);
        Task<List<Currency>> GetAllCurrencyAsync();
        Task<Currency> GetCurrencyAsync(string currencyName);
    }
}
