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

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task CreateDepartmentAsync(Department department)
        {
            await _departmentRepository.AddAsync(department);
        }

        public async Task DeleteDepartmentAsync(int departmentId)
        {
            await _departmentRepository.DeactivateAsync(departmentId);
        }

        public async Task<Department> GetDepartmentAsync(int departmentId)
        {
            return await _departmentRepository.GetByIdAsync(departmentId); 
        }

        public async  Task<List<Department>> GetDepartmentAsync()
        {
            return await _departmentRepository.GetAllAsync(x => x.IsActive == true);
        }

        public async Task UpdateDepartmentAsync(Department department)
        {
            await _departmentRepository.UpdateAsync(department);
        }
    }
}
