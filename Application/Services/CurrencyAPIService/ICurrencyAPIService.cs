using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CurrencyAPIService
{
    public interface ICurrencyAPIService
    {
        Task<List<string>> GetAllCurrencyData(string action);
        Task<List<string>> GetAllCurrency(string currency);
    }
}
