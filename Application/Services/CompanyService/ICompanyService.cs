using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanyService
{
    public interface ICompanyService
    {
        Task<Company> GetCompanyAsync(int  companyId);
    }
}
