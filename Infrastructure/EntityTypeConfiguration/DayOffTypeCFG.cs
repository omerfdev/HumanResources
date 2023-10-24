using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class DayOffTypeCFG : BaseEntityConfiguration<DayOffType>
    {
        public override void Configure(EntityTypeBuilder<DayOffType> builder)
        {
          

            builder.HasData(new DayOffType
            {
             DayOffTypeId=1,
             DayOffTypeName="Wedding Permit Day Off",
             DayOffTypeDuration=3,             
            },
            new DayOffType
            {
                DayOffTypeId = 2,
                DayOffTypeName = "Parents Permit Day Off",
                DayOffTypeDuration = 5,
            },
            new DayOffType
            {
                DayOffTypeId = 3,
                DayOffTypeName = "Maternity Permit Day Off",
                DayOffTypeDuration = 30,
            },
            new DayOffType
            {
                DayOffTypeId = 4,
                DayOffTypeName = "Funeral Permit Day Off",
                DayOffTypeDuration = 3,
            }, 
            new DayOffType
            {
                DayOffTypeId = 5,
                DayOffTypeName = "Sick Permit Day Off",
                DayOffTypeDuration = 3,
            },
            new DayOffType
            {
                DayOffTypeId = 6,
                DayOffTypeName = "Weekly Permit Day Off",
                DayOffTypeDuration = 2,
            },
            new DayOffType
            {
                DayOffTypeId = 7,
                DayOffTypeName = "Marrisge Permit Day Off",
                DayOffTypeDuration = 5,
            }
            );

            base.Configure(builder);
        }
    }
}
