using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CurrencyAPIService
{
    public class CurrencyAPIService : ICurrencyAPIService
    {
        public Task<List<string>> GetAllCurrency(string currency)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetAllCurrencyData(string action)
        {
            throw new NotImplementedException();
        }
    }
}
