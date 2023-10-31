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
        Task CreateDepartmentAsync(Department department);
        Task UpdateDepartmentAsync(Department department);
        Task DeleteDepartmentAsync(int departmentId);
        Task<Department> GetDepartmentAsync(int departmentId);
        Task<List<Department>> GetDepartmentAsync();
    }
}
