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
    public class CreatePDFCFG : BaseEntityConfiguration<CreatePDF>
    {
        public override void Configure(EntityTypeBuilder<CreatePDF> builder)
        {
            builder.ToTable("CreatePDF");

            base.Configure(builder);
        }
    }


}
