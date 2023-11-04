using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Services.AddressAPIService
{
    public class AddressAPIService : IAddressAPIService
    {
        private readonly IAddressAPIService _addressAPIService;

        public AddressAPIService(IAddressAPIService addressAPIService)
        {
            _addressAPIService = addressAPIService;
        }     

        public async Task<List<string>> GetAllAddressData(string action)
        {

            string apiUrl = "";
            List<string> addressData = new List<string>();
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
                    addressData = JsonConvert.DeserializeObject<List<string>>(readData.Result);
                }
            }
            return addressData;
        }

        public async Task<List<string>> GetCityAsync()
        {
            return await _addressAPIService.GetAllAddressData("GetCity");
        }

        public async Task<List<string>> GetDistrictAsync(string city, string town)
        {
            return await _addressAPIService.GetAllAddressData($"GetDistricts?town={town}&city={city}");
        }

        public async Task<List<string>> GetNeighbourAsync(string city, string town, string district)
        {
            return await _addressAPIService.GetAllAddressData($"GetNeigbours?district={district}&town={town}&city={city}");
        }

        public async  Task<List<string>> GetTownAsync(string city)
        {
            return await _addressAPIService.GetAllAddressData($"GetTowns?city={city}");
        }
    }
}
