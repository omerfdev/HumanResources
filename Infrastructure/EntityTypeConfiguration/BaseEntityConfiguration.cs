using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Abstract;

namespace Infrastructure.EntityTypeConfiguration
{
    public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {

            builder.Property(x => x.IsActive).IsRequired().HasDefaultValue(true);
        }
    }
}
