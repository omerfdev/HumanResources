using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.AddressAPIService
{
    public interface IAddressAPIService
    {
        Task<List<string>> GetAllData(string action);
        Task<List<string>> GetCityAsync();
        Task<List<string>> GetTownAsync(string city);
        Task<List<string>> GetDistrictAsync(string city,string town);
        Task<List<string>> GetNeighbourAsync(string city,string town,string district);
    }
}
