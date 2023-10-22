using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class CompanyCFG:BaseEntityConfiguration<Company>
    {

        public override void Configure(EntityTypeBuilder<Company> builder)
        {
           

            base.Configure(builder);
        }
    }
}
