using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        public Task<Company> GetCompany(int companyId)
        {
            throw new NotImplementedException();
        }
    }
}
