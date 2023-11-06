using Application.Models.DTOs.DepartmentDTO;
using Application.Models.DTOs.SpendingDTO;
using AutoMapper;
using Domain.Entities.Concrete;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateDepartmentAsync(AddDepartmentDTO AddDepartmentDTO)
        {
          Department department=_mapper.Map<Department>(AddDepartmentDTO);
            await _departmentRepository.AddAsync(department);
            return await _departmentRepository.UpdateAsync(department);
        }

        public async Task DeleteDepartmentAsync(int departmentId)
        {
            await _departmentRepository.DeactivateAsync(departmentId);
        }

        public async Task<Department> GetDepartmentAsync(int departmentId)
        {
            return await _departmentRepository.GetByIdAsync(departmentId);
        }

        public async Task<List<Department>> GetDepartmentWithCompanyAsync(int companyId)
        {
            return await _departmentRepository.GetAllAsync(x=>x.IsActive==true && x.CompanyId==companyId);
        }

        public async Task<int> UpdateDepartmentAsync(UpdateDepartmentDTO UpdateDepartmentDTO)
        {
            Department department = await _departmentRepository.GetFirstOrDefaultAsync(x => x.DepartmentId ==UpdateDepartmentDTO.DepartmentId);
            _mapper.Map(department, UpdateDepartmentDTO);
            return await _departmentRepository.UpdateAsync(department);
        }
    }
}
