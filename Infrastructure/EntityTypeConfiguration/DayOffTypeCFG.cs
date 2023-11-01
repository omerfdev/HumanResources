using Domain.Entities.Concrete;
using Domain.Entities.Enum;
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
                DayOffTypeId = 1,
                DayOffTypeName = "Wedding Permit Day Off",
                DayOffTypeDuration = 3,
                Gender = Gender.Female
            },
            new DayOffType
            {
                DayOffTypeId = 2,
                DayOffTypeName = "Parents Permit Day Off",
                DayOffTypeDuration = 5,
                Gender = Gender.Male
            },
            new DayOffType
            {
                DayOffTypeId = 3,
                DayOffTypeName = "Maternity Permit Day Off",
                DayOffTypeDuration = 30,
                Gender = Gender.Female
            },
            new DayOffType
            {
                DayOffTypeId = 4,
                DayOffTypeName = "Funeral Permit Day Off",
                DayOffTypeDuration = 3,
                Gender = Gender.Female
            },
            new DayOffType
            {
                DayOffTypeId = 5,
                DayOffTypeName = "Sick Permit Day Off",
                DayOffTypeDuration = 3,
                Gender = Gender.Female
            },
            new DayOffType
            {
                DayOffTypeId = 6,
                DayOffTypeName = "Weekly Permit Day Off",
                DayOffTypeDuration = 2,
                Gender = Gender.Female
            },
            new DayOffType
            {
                DayOffTypeId = 7,
                DayOffTypeName = "Marriage Permit Day Off",
                DayOffTypeDuration = 5,
                Gender = Gender.Female
            }, new DayOffType{
                DayOffTypeId = 8,
                DayOffTypeName = "Wedding Permit Day Off",
                DayOffTypeDuration = 3,
                Gender = Gender.Male
            },
        
            new DayOffType
            {
                DayOffTypeId = 9,
                DayOffTypeName = "Maternity Permit Day Off",
                DayOffTypeDuration = 30,
                Gender = Gender.Male
            },
            new DayOffType
            {
                DayOffTypeId = 10,
                DayOffTypeName = "Funeral Permit Day Off",
                DayOffTypeDuration = 3,
                Gender = Gender.Male
            },
            new DayOffType
            {
                DayOffTypeId =11,
                DayOffTypeName = "Sick Permit Day Off",
                DayOffTypeDuration = 3,
                Gender = Gender.Male
            },
            new DayOffType
            {
                DayOffTypeId = 12,
                DayOffTypeName = "Weekly Permit Day Off",
                DayOffTypeDuration = 2,
                Gender = Gender.Male
            },
            new DayOffType
            {
                DayOffTypeId = 13,
                DayOffTypeName = "Marriage Permit Day Off",
                DayOffTypeDuration = 5,
                Gender = Gender.Male
            }
            );

            base.Configure(builder);
        }
    }
}
