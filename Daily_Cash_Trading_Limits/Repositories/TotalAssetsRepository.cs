using System;
using System.Collections.Generic;
using Daily_Cash_Trading_Limits.Models;

namespace Daily_Cash_Trading_Limits.Repositories
{
    public interface ITotalAssetsRepository
    {
        IEnumerable<TotalAssets> GetAll();
        TotalAssets GetLimit(int bankId);
        void Add(TotalAssets item);
        TotalAssets Update(TotalAssets item);
        void Delete(TotalAssets item);
    }

    public class TotalAssetsRepository : ITotalAssetsRepository
    {
        public void Add(TotalAssets item)
        {
            throw new NotImplementedException();
        }

        public void Delete(TotalAssets item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TotalAssets> GetAll()
        {
            List<TotalAssets> assetList = new List<TotalAssets>()
            {
                new TotalAssets()
                {
                    BankId = 1,
                    BankName = "Bank 1",
                    Rating = 1,
                    Assets = 1000000,
                    DateApplied = System.DateTime.Now
                },
                new TotalAssets()
                {
                    BankId = 2,
                    BankName = "Bank 2",
                    Rating = 2,
                    Assets = 2000000,
                    DateApplied = System.DateTime.Now
                },
                new TotalAssets()
                {
                    BankId = 3,
                    BankName = "Bank 3",
                    Rating = 3,
                    Assets = 3000000,
                    DateApplied = System.DateTime.Now
                },
                new TotalAssets()
                {
                    BankId = 4,
                    BankName = "Bank 4",
                    Rating = 4,
                    Assets = 4000000,
                    DateApplied = System.DateTime.Now
                },
                new TotalAssets()
                {
                    BankId = 5,
                    BankName = "Bank 5",
                    Rating = 5,
                    Assets = 5000000,
                    DateApplied = System.DateTime.Now
                }
            };

            return assetList;
        }

        public TotalAssets GetLimit(int bankId)
        {
            return new TotalAssets()
            {
                BankId = bankId,
                BankName = $"Bank {bankId}",
                Rating = 1,
                Assets = 1000000,
                DateApplied = System.DateTime.Now
            };
        }

        public TotalAssets Update(TotalAssets item)
        {
            throw new NotImplementedException();
        }
    }
}
