﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        //private readonly DatabaseContext _context;

        //public RiskRatingRepository(DatabaseContext context)
        //{
        //    _context = context;
        //}

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
            //using (DatabaseContext _context = new DatabaseContext())
            //{
            //    IEnumerable<RiskRating> query =
            //        from riskRating in _context.RiskRatings.AsEnumerable()
            //        select riskRating;
            //    return query;
            //}

            return new List<RiskRating>
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
                };
        }

        public RiskRating GetRiskRating(int rating)
        {
            //using (DatabaseContext _context = new DatabaseContext())
            //{
            //    return _context.RiskRatings.FirstOrDefault(x => x.Rating == rating);
            //}

            return new RiskRating()
            {
                Rating = rating,
                EffectOnLimit = 0.13
            };
        }

        public RiskRating Update(RiskRating item)
        {
            throw new NotImplementedException();
        }
    }
}
