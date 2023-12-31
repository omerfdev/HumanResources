﻿using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.AddressService
{
    public interface IAddressService
    {
        Task<Address> GetUserAddressAsync(int userId);
    }
}
