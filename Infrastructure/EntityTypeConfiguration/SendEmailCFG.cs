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
    public class SendEmailCFG:BaseEntityConfiguration<SendEmail>
    {
        public override void Configure(EntityTypeBuilder<SendEmail> builder)
        {
            builder.ToTable("SendEmails");
        
            base.Configure(builder);
        }
    }
}
