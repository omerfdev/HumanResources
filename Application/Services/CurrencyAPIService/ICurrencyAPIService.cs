using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CurrencyAPIService
{
    public interface ICurrencyAPIService
    {
        Task<List<string>> GetAllCurrencyDataAsync(string action);
        Task<List<string>> GetCurrencyAsync(string currency);
    }
}
