using System;
using System.Collections.Generic;
using System.Linq;
using Daily_Cash_Trading_Limits.Models;

using Daily_Cash_Trading_Limits.Repositories;

namespace Daily_Cash_Trading_Limits.Services
{
    public interface IBankService
    {
        List<BankTradingInfoModel> GetAllBanksInfo();
        BankTradingInfoModel GetBankInfo(int bankId);
    }

    public class BankService : IBankService
    {
        private readonly ITotalAssetsRepository _totalAssetsRepo;
        private readonly IDailyCalculatedLimitRepository _dailyCalculatedLimitRepo;

        public BankService(
            ITotalAssetsRepository totalAssetsRepo,
            IDailyCalculatedLimitRepository dailyCalculatedLimitRepo)
        {
            _totalAssetsRepo = totalAssetsRepo;
            _dailyCalculatedLimitRepo = dailyCalculatedLimitRepo;
        }


        public List<BankTradingInfoModel> GetAllBanksInfo()
        {
            List<TotalAssets> totalAssetsQuery = _totalAssetsRepo.GetAll().ToList();
            List<DailyCalculatedLimit> ratingQuery = _dailyCalculatedLimitRepo.GetAll().ToList();

            List<BankTradingInfoModel> bankTradingInfoList = totalAssetsQuery.Select(x => new BankTradingInfoModel()
            {
                BankName = x.BankName,
                Rating = x.Rating,
                TotalAssets = x.Assets,
                DateApplied = x.DateApplied,
                CalculatedLimit = ratingQuery 
                                    .Where(y => x.BankId == y.BankId)
                                    .Select(y => y.Limit)
                                    .FirstOrDefault()
            }).ToList();

            return bankTradingInfoList;
        }

        public BankTradingInfoModel GetBankInfo(int bankId)
        {
            TotalAssets totalAssetsQuery = _totalAssetsRepo.GetLimit(bankId);
            DailyCalculatedLimit ratingQuery = _dailyCalculatedLimitRepo.GetCalculatedLimit(bankId);

            return new BankTradingInfoModel()
            {
                BankName = totalAssetsQuery.BankName,
                Rating = totalAssetsQuery.Rating,
                TotalAssets = totalAssetsQuery.Assets,
                DateApplied = totalAssetsQuery.DateApplied,
                CalculatedLimit = ratingQuery.Limit
            };
        }
    }
}

/*

    public class BankTradingInfoModel
    {
        public string bankName { get; set; }

        public int rating { get; set; }

        public long totalAssets { get; set; }

        public long calculatedLimit { get; set; }

        public DateTime date { get; set; }
    }

    [Table("TotalAssets")]
    public class TotalAssets
    {
        [ForeignKey("BankName")]
        public int bankId { get; set; }

        public string bankName { get; set; }

        [ForeignKey("RiskRating")]
        public int rating { get; set; }

        public long totalAssets { get; set; }

        public DateTime date { get; set; }
    }

    [Table("RiskRating")]
    public class RiskRating
    {
        [Key]
        public int riskRating { get; set; }

        public double effectOnLimit { get; set; }
    }


 */

//FinancialStats stats = new FinancialStats();
//var foodSold = _foodRepo.GetAllSold();
//var ticketsSold = _ticketRepo.GetAllSold();

////Calculate Average Stats
//stats.AverageTicketProfit =
//ticketsSold.Sum(x => x.Profit) / ticketsSold.Sum(x => x.Quantity);
//stats.AverageFoodItemProfit =
//foodSold.Sum(x => x.Profit) / foodSold.Sum(x => x.Quantity);

//return stats;

/*
 var q=(from pd in dataContext.tblProducts 
     join od in dataContext.tblOrders on pd.ProductID equals od.ProductID 
     orderby od.OrderID 
     select new { 
     od.OrderID,
     pd.ProductID,
     pd.Name,
     pd.UnitPrice,
     od.Quantity,
     od.Price,
     }).ToList(); 
 */

/*
    var results = from x in context.MyEntities 
      select new Customer() 
      { 
        CustomerID = x.CustomerID, 
        FirstName = x.FirstName, 
        LastName = x.LastName, 
        Gender = x.Gender, 
        BirthMonth = x.BirthMonth,
        TotalPurchases = context.PurchaseOrders
                                .Where(po=>po.CustomerId == x.CustomerId)
                                

      };
 */

/*

    public class BankTradingInfoModel
    {
        public string bankName { get; set; }

        public int rating { get; set; }

        public long totalAssets { get; set; }

        public long calculatedLimit { get; set; }

        public DateTime date { get; set; }
    }
 */