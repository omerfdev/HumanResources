using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfiguration
{
    public class CurrencyCFG : BaseEntityConfiguration<Currency>
    {

        public override void Configure(EntityTypeBuilder<Currency> builder)
        {

            builder.HasData(new Currency()
            {
                CurrencyId = 1,
                Code = "TRY",
                Name = "Türk Lirası",
                ExchangeRate = 1,
                IsActive = true
            },
            new Currency()
            {
                CurrencyId = 2,
                Code = "USD",
                Name = "Amerikan Doları",
                ExchangeRate = 28,
                IsActive = true
            },
            new Currency()
            {
                CurrencyId = 3,
                Code = "EUR",
                Name = "Euro",
                ExchangeRate = 29,
                IsActive = true
            },
            new Currency()
            {
                CurrencyId = 4,
                Code = "CAD",
                Name = "Kanada Doları",
                ExchangeRate = 22,
                IsActive = true
            }
           );
           
            base.Configure(builder);
        }

    }
}
