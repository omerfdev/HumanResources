using Domain.Entities.Concrete;
using Infrastructure.EntityTypeConfiguration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HrELP.Infrastructure
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<AppUser>? AppUsers { get; set; }
        public DbSet<AppRole>? AppRoles { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Spending>? Spendings { get; set; }
        public DbSet<SpendingType>? SpendingsType { get; set; }
        public DbSet<CompanyDepartment>? CompanyDepartments { get; set; }
        public DbSet<Currency>? Currencys { get; set; }
        public DbSet<DayOff>? DayOffs { get; set; }
        public DbSet<DayOffType>? DayOffTypes { get; set; }
        public DbSet<DayOffAppUser>? DayOffAppUsers { get; set; }
        public DbSet<Department>? Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:hrelp-server.database.windows.net,1433;Initial Catalog=hrelpDB;Persist Security Info=False;User ID=hrelp;Password=Admin_123.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;");


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<AppRole>(new AppRoleCFG());
            builder.ApplyConfiguration<AppUser>(new AppUserCFG());
            builder.ApplyConfiguration<Address>(new AddressCFG());
            builder.ApplyConfiguration<Company>(new CompanyCFG());
            builder.ApplyConfiguration<Spending>(new SpendingCFG());
            builder.ApplyConfiguration<SpendingType>(new SpendingTypeCFG());
            builder.ApplyConfiguration<CompanyDepartment>(new CompanyDepartmentCFG());
            builder.ApplyConfiguration<Department>(new DepartmentCFG());
            builder.ApplyConfiguration<Currency>(new CurrencyCFG());
            builder.ApplyConfiguration<DayOff>(new DayOffCFG());
            builder.ApplyConfiguration<DayOffType>(new DayOffTypeCFG());
            builder.ApplyConfiguration<DayOffAppUser>(new DayOffAppUserCFG());

            

            base.OnModelCreating(builder);
        }
    }
}
