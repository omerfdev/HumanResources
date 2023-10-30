using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CurrencyService
{
    public class CurrencyService : ICurrencyService
    {
        public Task<Currency> GetCurrencyAsync(int currencyId)
        {
            throw new NotImplementedException();
        }
    }
}
