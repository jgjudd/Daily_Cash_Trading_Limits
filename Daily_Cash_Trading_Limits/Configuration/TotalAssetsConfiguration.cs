using System;
using System.Collections.Generic;
using Daily_Cash_Trading_Limits.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Daily_Cash_Trading_Limits.Configuration
{
    public class TotalAssetsConfiguration : IEntityTypeConfiguration<TotalAsset>
    {
        public void Configure(EntityTypeBuilder<TotalAsset> builder)
        {
            builder.ToTable("TotalAssets");
            builder.Property(s => s.BankId)
                .IsRequired(true);
            builder.HasData
            (
                new List<TotalAsset>
                {
                    new TotalAsset()
                    {
                        BankId = 1,
                        BankName = "Bank 1",
                        Rating = 1,
                        Assets = 1000000,
                        DateApplied = System.DateTime.Now
                    },
                    new TotalAsset()
                    {
                        BankId = 2,
                        BankName = "Bank 2",
                        Rating = 2,
                        Assets = 2000000,
                        DateApplied = System.DateTime.Now
                    },
                    new TotalAsset()
                    {
                        BankId = 3,
                        BankName = "Bank 3",
                        Rating = 3,
                        Assets = 3000000,
                        DateApplied = System.DateTime.Now
                    },
                    new TotalAsset()
                    {
                        BankId = 4,
                        BankName = "Bank 4",
                        Rating = 4,
                        Assets = 4000000,
                        DateApplied = System.DateTime.Now
                    },
                    new TotalAsset()
                    {
                        BankId = 5,
                        BankName = "Bank 5",
                        Rating = 5,
                        Assets = 5000000,
                        DateApplied = System.DateTime.Now
                    }
                }
            );
        }
    }
}
