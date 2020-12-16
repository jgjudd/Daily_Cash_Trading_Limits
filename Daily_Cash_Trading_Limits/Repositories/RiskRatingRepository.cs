using System;
using System.Collections.Generic;
using Daily_Cash_Trading_Limits.Models;

namespace Daily_Cash_Trading_Limits.Repositories
{
    public interface IRiskRatingRepository
    {
        IEnumerable<RiskRating> GetAll();
        RiskRating GetRiskRating(int rating);
        void Add(RiskRating item);
        RiskRating Update(RiskRating item);
        void Delete(RiskRating item);
    }

    public class RiskRatingRepository : IRiskRatingRepository
    {
        public void Add(RiskRating item)
        {
            throw new NotImplementedException();
        }

        public void Delete(RiskRating item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RiskRating> GetAll()
        {
            List<RiskRating> riskRatings = new List<RiskRating>()
            {
                new RiskRating()
                {
                    Rating = 1,
                    EffectOnLimit = 0.10
                },
                new RiskRating()
                {
                    Rating = 2,
                    EffectOnLimit = 0.20
                },
                new RiskRating()
                {
                    Rating = 3,
                    EffectOnLimit = 0.30
                },
                new RiskRating()
                {
                    Rating = 4,
                    EffectOnLimit = 0.40
                },
                new RiskRating()
                {
                    Rating = 5,
                    EffectOnLimit = 0.50
                },
            };

            return riskRatings;
        }

        public RiskRating GetRiskRating(int rating)
        {
            return new RiskRating()
            {
                Rating = rating,
                EffectOnLimit = 0.10
            };
        }

        public RiskRating Update(RiskRating item)
        {
            throw new NotImplementedException();
        }
    }
}
