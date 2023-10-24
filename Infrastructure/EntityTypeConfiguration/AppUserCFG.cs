using Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class AppUserCFG : BaseEntityConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.SecondName).IsRequired(false).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.SecondSurname).IsRequired(false).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.Photo).IsRequired(false);
            builder.Property(x => x.CitizenId).IsRequired().HasMaxLength(11).HasColumnType("varchar");
            builder.Property(x => x.AppRoleId).IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.BirthPlace).IsRequired(false).HasMaxLength(30).HasColumnType("varchar");
            builder.HasOne(x => x.Address).WithOne(x => x.AppUser).HasForeignKey<Address>(x => x.AppUserId);

            PasswordHasher<AppUser> hashPwd = new PasswordHasher<AppUser>();

            AppUser root = new AppUser()
            {
                Id = 1,
                AppRoleId = 1,
                FirstName = "Gamze",
                Surname = "Altınelli",
                SecurityStamp = Guid.NewGuid().ToString(),
                Photo = "~/images/profilepic/GamzeAltınelli.png",
                CitizenId = "11111111111",
                HireDate = DateTime.Now,
                BirthDate = DateTime.Now,
                BirthPlace = "Istanbul",
                CompanyId = 1,
                Profession = "Computer Engineer",
                DepartmentId = 1,
                AddressId = 1,
                
                Salary = 30000M
            };
            AppUser employee = new AppUser()
            {
                Id = 2,
                AppRoleId = 2,
                FirstName = "Omer Faruk",
                Surname = "ALMALI",
                SecurityStamp = Guid.NewGuid().ToString(),
                Photo = "~/images/profilepic/GamzeAltınelli.png",
                CitizenId = "23182273390",
                HireDate = DateTime.Now,
                BirthDate = DateTime.Now,
                BirthPlace = "Istanbul",
                CompanyId = 1,
                Profession = "Computer Engineer",
                DepartmentId = 1,
                AddressId = 1,
                Salary = 30000M
            };
            AppUser employee2 = new AppUser()
            {
                Id = 3,
                AppRoleId = 3,
                FirstName = "Sabri",
                Surname = "SEN",
                SecurityStamp = Guid.NewGuid().ToString(),
                Photo = "~/images/profilepic/GamzeAltınelli.png",
                CitizenId = "23188299902",
                HireDate = DateTime.Now,
                BirthDate = DateTime.Now,
                BirthPlace = "Istanbul",
                CompanyId = 1,
                Profession = "Computer Engineer",
                DepartmentId = 1,
                AddressId = 1,
                Salary = 30000M
            };
            employee2.PasswordHash = hashPwd.HashPassword(employee, "Sabri_1234");
            employee2.Email = $"sabrisen97@gmail.com";
            employee2.UserName = employee.Email;
            employee.PasswordHash = hashPwd.HashPassword(employee, "Omer_1234");
            employee.Email = $"omeralmali1@gmail.com";
            employee.UserName = employee.Email;
            root.PasswordHash = hashPwd.HashPassword(root, "Mngr_1234.");
            root.Email = $"gamze.altinelli@bilgeadamboost.com";
            root.UserName = root.Email;
            builder.HasData(employee);
            builder.HasData(employee2);
            builder.HasData(root);

            base.Configure(builder);
        }
    }
}
