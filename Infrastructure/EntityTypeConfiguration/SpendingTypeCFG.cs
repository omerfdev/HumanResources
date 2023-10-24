using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class SpendingTypeCFG : BaseEntityConfiguration<SpendingType>
    {

        public override void Configure(EntityTypeBuilder<SpendingType> builder)
        {
            builder.HasData(new SpendingType()
            {
               SpendingName = "Education",
               SpendingTypeId=1,
                IsActive = true
            },
            new SpendingType()
            {
                SpendingName = "Travel",
                SpendingTypeId = 2,
                IsActive = true
            },
             new SpendingType()
             {
                 SpendingName = "Seminar",
                 SpendingTypeId = 3,
                 IsActive = true
             }
            );
            base.Configure(builder);
        }

    }
}
