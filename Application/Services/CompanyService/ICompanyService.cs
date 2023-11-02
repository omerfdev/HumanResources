using Application.Models.DTOs.CompanyDTO;
using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanyService
{
    public interface ICompanyService
    {
        Task<Company> GetCompanyAsync(int  companyId);
        Task AddCompanyAsync(AddCompanyDTO addcompanyDTO);
        Task<List<Company>> GetCompanyAsync();
        Task<List<Company>> GetCompanyAsync(Expression<Func<Company, bool>> predicate, params Expression<Func<Company, object>>[] includes);
        Task<int> UpdateCompanyAsync(Company updateCompany);
        Task<int> DeleteCompanyAsync(int id);
    }
}
