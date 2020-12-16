using System;
namespace Daily_Cash_Trading_Limits.Models
{
    public class BankTradingInfoModel
    {
        public string BankName { get; set; }

        public int Rating { get; set; }

        public long TotalAssets { get; set; }

        public long CalculatedLimit { get; set; }

        public DateTime DateApplied { get; set; }
    }
}
