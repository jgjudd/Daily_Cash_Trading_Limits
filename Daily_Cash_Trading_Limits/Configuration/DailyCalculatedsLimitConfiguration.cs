using System;
using System.Collections.Generic;
using Daily_Cash_Trading_Limits.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Daily_Cash_Trading_Limits.Configuration
{
    public class DailyCalculatedLimitsConfiguration : IEntityTypeConfiguration<DailyCalculatedLimit>
    {
        public void Configure(EntityTypeBuilder<DailyCalculatedLimit> builder)
        {
            long baseLimit = 2000000;

            builder.ToTable("DailyCalculatedLimits");
            builder.Property(s => s.BankId)
                .IsRequired(true);
            builder.HasData
            (
                new List<DailyCalculatedLimit>
                {
                    new DailyCalculatedLimit()
                    {
                        BankId = 1,
                        BaseLimit = baseLimit
                    },
                    new DailyCalculatedLimit()
                    {
                        BankId = 2,
                        BaseLimit = baseLimit
                    },
                    new DailyCalculatedLimit()
                    {
                        BankId = 3,
                        BaseLimit = baseLimit
                    },
                    new DailyCalculatedLimit()
                    {
                        BankId = 4,
                        BaseLimit = baseLimit
                    },
                    new DailyCalculatedLimit()
                    {
                        BankId = 5,
                        BaseLimit = baseLimit
                    }
                }
            );
        }
    }
}
