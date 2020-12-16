using System;
using Daily_Cash_Trading_Limits.Models;
using System.Linq;
using System.Collections.Generic;

namespace Daily_Cash_Trading_Limits.Repositories
{
    public interface IDailyCalculatedLimitRepository
    {
        IEnumerable<DailyCalculatedLimit> GetAll();
        DailyCalculatedLimit GetCalculatedLimit(int bankId);
        void Add(DailyCalculatedLimit item);
        DailyCalculatedLimit Update(DailyCalculatedLimit item);
        void Delete(DailyCalculatedLimit item);
    }

    public class DailyCalculatedLimitRepository : IDailyCalculatedLimitRepository
    {
        //private readonly DatabaseContext _context;

        //public DailyCalculatedLimitRepository(DatabaseContext context)
        //{
        //    _context = context;
        //}

        public void Add(DailyCalculatedLimit item)
        {
            throw new NotImplementedException();
        }

        public void Delete(DailyCalculatedLimit item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DailyCalculatedLimit> GetAll()
        {
            //using (DatabaseContext _context = new DatabaseContext())
            //{
            //    IEnumerable<DailyCalculatedLimit> query =
            //            from dailyCalculatedLimit in _context.DailyCalculatedLimits.AsEnumerable()
            //            select dailyCalculatedLimit;
            //    return query;
            //}

            long baseLimit = 2000000;

            return new List<DailyCalculatedLimit>
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
                    },
                    new DailyCalculatedLimit()
                    {
                        BankId = 6,
                        BaseLimit = baseLimit
                    },
                    new DailyCalculatedLimit()
                    {
                        BankId = 2=7,
                        BaseLimit = baseLimit
                    },
                    new DailyCalculatedLimit()
                    {
                        BankId = 8,
                        BaseLimit = baseLimit
                    },
                    new DailyCalculatedLimit()
                    {
                        BankId = 9,
                        BaseLimit = baseLimit
                    },
                    new DailyCalculatedLimit()
                    {
                        BankId = 10,
                        BaseLimit = baseLimit
                    },
                };
        }

        public DailyCalculatedLimit GetCalculatedLimit(int bankId)
        {
            //using (DatabaseContext _context = new DatabaseContext())
            //{
            //    return _context.DailyCalculatedLimits.FirstOrDefault(x => x.BankId == bankId);
            //}

            long baseLimit = 2000000;

            return new DailyCalculatedLimit()
            {
                BankId = 5,
                BaseLimit = baseLimit
            };
        }

        public DailyCalculatedLimit Update(DailyCalculatedLimit item)
        {
            throw new NotImplementedException();
        }
    }
}
