using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.AddressService
{
    public class AddressService : IAddressService
    {
        public Task<Address> GetUserAddressAsync()
        {
            throw new NotImplementedException();
        }
    }
}
