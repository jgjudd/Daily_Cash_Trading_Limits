using System;
using System.Collections.Generic;
using Daily_Cash_Trading_Limits.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Daily_Cash_Trading_Limits.Configuration
{
    public class BankNamesConfiguration : IEntityTypeConfiguration<BankName>
    {
        public void Configure(EntityTypeBuilder<BankName> builder)
        {
            builder.ToTable("BankNames");
            builder.Property(s => s.BankId)
                .IsRequired(true);
            builder.HasData
            (
                new List<BankName>
                {
                    new BankName()
                    {
                        BankId = 1,
                        Name = "Bank 1",
                        Approved = true
                    },
                    new BankName()
                    {
                        BankId = 2,
                        Name = "Bank 2",
                        Approved = true
                    },
                    new BankName()
                    {
                        BankId = 3,
                        Name = "Bank 3",
                        Approved = false
                    },
                    new BankName()
                    {
                        BankId = 4,
                        Name = "Bank 4",
                        Approved = true
                    },
                    new BankName()
                    {
                        BankId = 5,
                        Name = "Bank 5",
                        Approved = true
                    }
                }
            ); 
        }
    }
}
