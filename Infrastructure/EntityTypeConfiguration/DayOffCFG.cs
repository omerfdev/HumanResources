using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class DayOffCFG : BaseEntityConfiguration<DayOff>
    {
        public override void Configure(EntityTypeBuilder<DayOff> builder)
        {
            builder.HasData(new DayOff()
            {
                DayOffId = 1,
                DayOffDayNumber = 10,
                Gender = Domain.Entities.Enum.Gender.Male,
                RequestTime = DateTime.Now,
                EmployeeId = 3,
                DayOffTypeId = 1,
                Description="İzin",
                Status=Domain.Entities.Enum.Status.Success,
                CreateTime = DateTime.Now,
                IsActive = true
            }
            );
            base.Configure(builder);
        }

    }
}
