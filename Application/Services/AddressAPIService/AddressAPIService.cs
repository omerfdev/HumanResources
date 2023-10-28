using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.AddressAPIService
{
    public class AddressAPIService : IAddressAPIService
    {
        public Task<List<string>> GetAllData(string action)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetCityAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetDistrictAsync(string city, string town)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetNeighbourAsync(string city, string town, string district)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetTownAsync(string city)
        {
            throw new NotImplementedException();
        }
    }
}
