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
            List<DailyCalculatedLimit> limitList = new List<DailyCalculatedLimit>()
            {
                new DailyCalculatedLimit()
                {
                    BankId = 1,
                    Limit = 2000000
                },
                new DailyCalculatedLimit()
                {
                    BankId = 2,
                    Limit = 2000000
                },
                new DailyCalculatedLimit()
                {
                    BankId = 3,
                    Limit = 2000000
                },
                new DailyCalculatedLimit()
                {
                    BankId = 4,
                    Limit = 2000000
                },
                new DailyCalculatedLimit()
                {
                    BankId = 5,
                    Limit = 2000000
                }
            };

            return limitList;
        }

        public DailyCalculatedLimit GetCalculatedLimit(int bankId)
        {
            return new DailyCalculatedLimit()
            {
                BankId = bankId,
                Limit = 2000000
            };
        }

        public DailyCalculatedLimit Update(DailyCalculatedLimit item)
        {
            throw new NotImplementedException();
        }
    }
}
