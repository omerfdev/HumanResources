using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class DepartmentCFG:BaseEntityConfiguration<Department>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(e => e.DepartmentName).HasMaxLength(80).HasColumnType("varchar").IsRequired();
            builder.HasMany(x => x.Employees).WithOne(x => x.Department);

            builder.HasData(new Department()
            {
              
                CompanyId = 1,
                DepartmentId = 1,
                DepartmentName = "IT",
                IsActive = true
            }, new Department()
            {
               
                CompanyId = 1,
                DepartmentId = 2,
                DepartmentName ="Sales Team",
                IsActive = true
            },
            new Department()
            {

                CompanyId = 1,
                DepartmentId = 3,
                DepartmentName = "Development Team",
                IsActive = true
            }
            );
            base.Configure(builder);
        }
    }
}
