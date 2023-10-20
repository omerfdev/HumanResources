using Domain.Entities.Concrete;
using HrELP.Infrastructure;
using HrELP.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(Context context) : base(context)
        {
        }
    }
}
