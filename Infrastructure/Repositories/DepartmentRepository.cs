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
    public class DepartmentRepository : BaseRepository<SpendingType>, ISpendingTypeRepository
    {
        public DepartmentRepository(Context context) : base(context)
        {
        }
    }
}
