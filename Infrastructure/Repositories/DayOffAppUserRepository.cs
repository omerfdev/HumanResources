using Domain.Entities.Concrete;
using Domain.Repositories;
using HrELP.Infrastructure.Repositories;
using HrELP.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DayOffAppUserRepository : BaseRepository<DayOffAppUser>, IDayOffAppUserRepository
    {
        public DayOffAppUserRepository(Context context) : base(context)
        {

        }
    }
}
