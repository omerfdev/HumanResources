using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class AppRoleCFG:BaseEntityConfiguration<AppRole>
    {
      
            public override void Configure(EntityTypeBuilder<AppRole> builder)
            {
                

                base.Configure(builder);
            }
        
    }
}
