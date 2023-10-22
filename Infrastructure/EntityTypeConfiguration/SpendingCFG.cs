using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class SpendingCFG:BaseEntityConfiguration<Spending>
    {
       
            public override void Configure(EntityTypeBuilder<Spending> builder)
            {
               

                base.Configure(builder);
            }
        
    }
}
