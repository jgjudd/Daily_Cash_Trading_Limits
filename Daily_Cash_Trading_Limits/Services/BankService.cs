using System;
using System.Collections.Generic;
using System.Linq;
using Daily_Cash_Trading_Limits.Models;

using Daily_Cash_Trading_Limits.Repositories;

namespace Daily_Cash_Trading_Limits.Services
{
    public interface IBankService
    {
        List<BankTradingInfo> GetAllBanksTradingInfo();
        BankTradingInfo GetBankTradingInfo(int bankId);
    }

    public class BankService : IBankService
    {
        private readonly ITotalAssetRepository _totalAssetRepo;
        private readonly IDailyCalculatedLimitRepository _dailyCalculatedLimitRepo;
        private readonly IBankNameRepository _bankNameRepo;
        private readonly IRiskRatingRepository _riskRatingRepo;

        public BankService(
            ITotalAssetRepository totalAssetRepo,
            IDailyCalculatedLimitRepository dailyCalculatedLimitRepo,
            IBankNameRepository bankNameRepo,
            IRiskRatingRepository riskRatingRepo)
        {
            _totalAssetRepo = totalAssetRepo;
            _dailyCalculatedLimitRepo = dailyCalculatedLimitRepo;
            _bankNameRepo = bankNameRepo;
            _riskRatingRepo =riskRatingRepo;
        }

        public long CalculateLimit(int rating, long totalAssets)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                long baseLimit = 2000000;
                RiskRating riskRatingQuery = _riskRatingRepo.GetRiskRating(rating);

                long limit = (long)((riskRatingQuery.EffectOnLimit * baseLimit) + baseLimit);

                if (totalAssets > 3000000)
                {
                    return (long)(limit + (limit * 0.23));
                }

                return limit;
            }
        }

        public List<BankTradingInfo> GetAllBanksTradingInfo()
        {

                List<TotalAsset> totalAssetsQuery = _totalAssetRepo.GetAll().ToList();
                List<DailyCalculatedLimit> ratingQuery = _dailyCalculatedLimitRepo.GetAll().ToList();
                List<BankName> bankListQuery = _bankNameRepo.GetAll().ToList();


                List<BankTradingInfo> bankTradingInfoList = totalAssetsQuery.Select(x => new BankTradingInfo()
                {
                    BankName = x.BankName,
                    Rating = x.Rating,
                    TotalAssets = x.Assets,
                    DateApplied = x.DateApplied,
                    CalculatedLimit = null,
                    Approved = bankListQuery
                                        .Where(z => x.BankId == z.BankId)
                                        .Select(z => z.Approved)
                                        .FirstOrDefault()
                }).ToList();



                foreach (BankTradingInfo item in bankTradingInfoList)
                {
                    item.CalculatedLimit = CalculateLimit(item.Rating, item.TotalAssets);
                }

                return bankTradingInfoList;
            

            
        }

        public BankTradingInfo GetBankTradingInfo(int bankId)
        {
            TotalAsset totalAssetsQuery = _totalAssetRepo.GetTotalAssetsInfo(bankId);
            DailyCalculatedLimit ratingQuery = _dailyCalculatedLimitRepo.GetCalculatedLimit(bankId);
            BankName bankInfo = _bankNameRepo.GetBank(bankId);

            BankTradingInfo info = new BankTradingInfo()
            {
                BankName = totalAssetsQuery.BankName,
                Rating = totalAssetsQuery.Rating,
                TotalAssets = totalAssetsQuery.Assets,
                DateApplied = totalAssetsQuery.DateApplied,
                CalculatedLimit = null,
                Approved = bankInfo.Approved
            };

            info.CalculatedLimit = CalculateLimit(info.Rating, info.TotalAssets);

            return info;
        }
    }
}
