using System;
using System.Collections.Generic;
using System.Linq;
using Daily_Cash_Trading_Limits.Models;
using Microsoft.EntityFrameworkCore;

namespace Daily_Cash_Trading_Limits.Repositories
{
    public interface ITotalAssetRepository
    {
        IEnumerable<TotalAsset> GetAll();
        TotalAsset GetTotalAssetsInfo(int bankId);
        void Add(TotalAsset item);
        TotalAsset Update(TotalAsset item);
        void Delete(TotalAsset item);
    }

    public class TotalAssetRepository : ITotalAssetRepository
    {
        // private readonly DatabaseContext _context;

        //public TotalAssetRepository(DatabaseContext context)
        //{
        //    _context = context;
        //}

        public void Add(TotalAsset item)
        {
            throw new NotImplementedException();
        }

        public void Delete(TotalAsset item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TotalAsset> GetAll()
        {
            //using (DatabaseContext _context = new DatabaseContext())
            //{
            //    IEnumerable<TotalAsset> query =
            //        from totalAsset in _context.TotalAssets.AsEnumerable()
            //        select totalAsset;
            //    return query;
            //}

            return new List<TotalAsset>
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
                };
        }

        public TotalAsset GetTotalAssetsInfo(int bankId)
        {
            //using (DatabaseContext _context = new DatabaseContext())
            //{
            //    return  _context.TotalAssets.FirstOrDefault(x => x.BankId == bankId);
            //}

            return new TotalAsset()
            {
                BankId = 5,
                BankName = "Bank 5",
                Rating = 5,
                Assets = 5000000,
                DateApplied = System.DateTime.Now
            };


        }

        public TotalAsset Update(TotalAsset item)
        {
            throw new NotImplementedException();
        }
    }
}
