using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class CompanyDepartmentCFG : BaseEntityConfiguration<CompanyDepartment>
    {

        public override void Configure(EntityTypeBuilder<CompanyDepartment> builder)
        {
          
            builder.HasData(new CompanyDepartment()
            {
                CompanyDepartmentId=1,
                CompanyId = 1,        
                DepartmentId = 1,
                IsActive = true
            }, new CompanyDepartment()
            {
                CompanyDepartmentId = 2,
                CompanyId = 1,
                DepartmentId = 2,
                IsActive = true
            }, new CompanyDepartment()
            {
                CompanyDepartmentId = 3,
                CompanyId = 1,
                DepartmentId = 3,
                IsActive = true
            }
            );
            base.Configure(builder);
        }

    }
}
