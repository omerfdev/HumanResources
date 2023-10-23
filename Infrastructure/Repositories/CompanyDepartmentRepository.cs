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
    public class CompanyDepartmentRepository : BaseRepository<CompanyDepartment>, ICompanyDepartmentRepository
    {
        public CompanyDepartmentRepository(Context context) : base(context)
        {
        }
    }
}
