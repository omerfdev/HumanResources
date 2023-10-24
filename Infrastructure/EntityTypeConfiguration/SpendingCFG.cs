using Domain.Entities.Concrete;
using Domain.Entities.Enum;
using Microsoft.EntityFrameworkCore;
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
            builder.HasKey(x => x.SpendingId);
            builder.Property(e => e.AmountOfSpending).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(x => x.RequestTime).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.ReplyTime).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DocumentPath).IsRequired(false).HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.IsActive).IsRequired().HasDefaultValue(true).HasColumnType("bit");
            builder.HasOne(x=>x.SpendingType).WithMany(x=>x.Spending).HasForeignKey(x=>x.SpendingId);
            builder.HasOne(x => x.Currency).WithMany(x => x.Spending).HasForeignKey(x => x.CurrencyId);
            builder.HasOne(x => x.Employee).WithMany(x => x.Spendings).HasForeignKey(x => x.EmployeeId);
            Spending expense = new Spending()
            {
                SpendingId = 1,
                EmployeeId = 1,
                AmountOfSpending = 10000,
                Status = Status.Pending,
                RequestTime = DateTime.Now,
                DocumentPath = "~/images/fatura.png",
                CreateTime = DateTime.Now,
                SpendingTypeId= 1,
                CurrencyId = 1,
                IsActive = true,               
            };
            builder.HasData(expense);
            base.Configure(builder);
            }
        
    }
}
