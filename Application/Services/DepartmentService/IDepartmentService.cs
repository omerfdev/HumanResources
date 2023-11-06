using Application.Models.DTOs.DepartmentDTO;
using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.DepartmentService
{
    public interface IDepartmentService
    {
        Task<int> CreateDepartmentAsync(AddDepartmentDTO AddDepartmentDTO);
        Task<int> UpdateDepartmentAsync(UpdateDepartmentDTO UpdateDepartmentDTO);
        Task DeleteDepartmentAsync(int departmentId);
        Task<Department> GetDepartmentAsync(int departmentId);
        Task<List<Department>> GetDepartmentWithCompanyAsync(int companyId);
    }
}
