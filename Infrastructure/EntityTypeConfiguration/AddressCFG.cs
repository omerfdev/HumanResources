using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class AddressCFG : BaseEntityConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(x => x.City).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            builder.Property(x => x.Town).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            builder.Property(x => x.District).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            builder.Property(x => x.Quarter).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            builder.Property(x => x.PostalCode).IsRequired().HasMaxLength(5).HasColumnType("int");        
            builder.HasOne(x => x.AppUser).WithOne(x => x.Address);

            builder.HasData(new Address
            {
                AppUserId = 1,
                AddressId = 1,
                City = "Bursa",
                Town = "Gemlik",
                District = "Gemlik",
                Quarter = "Ata Mh.",
                PostalCode = 16848,
               
            });

            base.Configure(builder);
        }
    }
}
