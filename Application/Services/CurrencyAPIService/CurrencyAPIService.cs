using Domain.Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CurrencyAPIService
{
    public class CurrencyAPIService : ICurrencyAPIService
    {
        private readonly ICurrencyAPIService _currencyAPIService;

        public CurrencyAPIService(ICurrencyAPIService currencyAPIService)
        {
            _currencyAPIService = currencyAPIService;
        }

        public async Task<List<string>> GetCurrencyAsync(string currency)
        {
            return await _currencyAPIService.GetAllCurrencyDataAsync("GetCurrency");
        }

        public async Task<List<string>> GetAllCurrencyDataAsync(string action)
        {

            string apiUrl = "";
            List<string> currencyData = new List<string>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                var response = client.GetAsync($"{action}");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readData = result.Content.ReadAsStringAsync();
                    readData.Wait();
                    currencyData = JsonConvert.DeserializeObject<List<string>>(readData.Result);
                }
            }
            return currencyData;
        }
    }
}
