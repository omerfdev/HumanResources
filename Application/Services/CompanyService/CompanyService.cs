using Application.Models.DTOs.CompanyDTO;
using AutoMapper;
using Domain.Entities.Concrete;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Application.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper _mapper;
        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            this.companyRepository = companyRepository;
            _mapper = mapper;
        }
        public async Task AddCompanyAsync(AddCompanyDTO addcompanyDTO)
        {
            Company newCompany = new Company();
            _mapper.Map(addcompanyDTO, newCompany);
            await companyRepository.AddAsync(newCompany);
        }

        public async Task<int> DeleteCompanyAsync(int id)
        {
           return await companyRepository.DeactivateAsync(id);
        }

        public async Task<List<Company>> GetCompanyAsync(int companyId)
        {
            return await companyRepository.GetAllAsync(x => x.IsActive == true);
        }

        public Task<List<Company>> GetCompanyAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Company>> GetCompanyAsync(Expression<Func<Company, bool>> predicate, params Expression<Func<Company, object>>[] includes)
        {
            return await companyRepository.GetAllAsync(c => c.IsActive == true, c => c.Addresses);
        }

        public async Task<Company> UpdateCompanyAsync(Company updateCompany)
        {
            return await companyRepository.UpdateAsync(updateCompany);
        }
    }
}
