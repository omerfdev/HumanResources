using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.EntityTypeConfiguration
{
    public class DayOffAppUserCFG : BaseEntityConfiguration<DayOffAppUser>
    {
        public override void Configure(EntityTypeBuilder<DayOffAppUser> builder)
        {
            
           

            builder.HasData(new DayOffAppUser
            {
                DayOffAppUserId = 1,
                AppUserId = 3,
                DayOffId = 1,
                Status=Domain.Entities.Enum.Status.Success,
                RequestTime=DateTime.Now,
                RequestDayOff=10
            });

            base.Configure(builder);
        }
    }
}
