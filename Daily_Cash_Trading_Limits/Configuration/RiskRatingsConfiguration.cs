using System;
using System.Collections.Generic;
using Daily_Cash_Trading_Limits.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Daily_Cash_Trading_Limits.Configuration
{
    public class RiskRatingsConfiguration : IEntityTypeConfiguration<RiskRating>
    {
        public void Configure(EntityTypeBuilder<RiskRating> builder)
        {
            builder.ToTable("RiskRatings");
            builder.Property(s => s.Rating)
                .IsRequired(true);
            builder.HasData
            (
                new List<RiskRating>
                {
                    new RiskRating()
                    {
                        Rating = -5,
                        EffectOnLimit = -0.12
                    },
                    new RiskRating()
                    {
                        Rating = -4,
                        EffectOnLimit = -0.12
                    },
                    new RiskRating()
                    {
                        Rating = -3,
                        EffectOnLimit = -0.12
                    },
                    new RiskRating()
                    {
                        Rating = -2,
                        EffectOnLimit = -0.09
                    },
                    new RiskRating()
                    {
                        Rating = -1,
                        EffectOnLimit = -0.09
                    },
                    new RiskRating()
                    {
                        Rating = 0,
                        EffectOnLimit = -0.09
                    },
                    new RiskRating()
                    {
                        Rating = 1,
                        EffectOnLimit = 0.05
                    },
                    new RiskRating()
                    {
                        Rating = 2,
                        EffectOnLimit = 0.05
                    },
                    new RiskRating()
                    {
                        Rating = 3,
                        EffectOnLimit = 0.05
                    },
                    new RiskRating()
                    {
                        Rating = 4,
                        EffectOnLimit = 0.08
                    },
                    new RiskRating()
                    {
                        Rating = 5,
                        EffectOnLimit = 0.08
                    },
                    new RiskRating()
                    {
                        Rating = 6,
                        EffectOnLimit = 0.08
                    },
                    new RiskRating()
                    {
                        Rating = 7,
                        EffectOnLimit = 0.13
                    },
                    new RiskRating()
                    {
                        Rating = 8,
                        EffectOnLimit = 0.13
                    },
                    new RiskRating()
                    {
                        Rating = 9,
                        EffectOnLimit = 0.13
                    },
                    new RiskRating()
                    {
                        Rating = 10,
                        EffectOnLimit = 0.13
                    }
                }
            );
        }
    }
}
