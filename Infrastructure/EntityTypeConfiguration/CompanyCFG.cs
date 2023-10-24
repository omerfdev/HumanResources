using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.EntityTypeConfiguration
{
    public class CompanyCFG:BaseEntityConfiguration<Company>
    {

        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.CompanyId);
            builder.HasMany(x => x.Employees).WithOne(x => x.Company);  
            builder.HasMany(x => x.Departments).WithOne(x => x.Company);  
            
            builder.HasData(new Company()
            {
                CompanyId = 1,
                CompanyName = "Bilge Adam",
                IsActive = true
            },new Company()
            {
                CompanyId = 2,
                CompanyName = "X Company",
                IsActive = true
            });
            base.Configure(builder);
        }
    }
}
