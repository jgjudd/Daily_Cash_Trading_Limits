using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daily_Cash_Trading_Limits.Models
{
    [Table("TotalAssets")]
    public class TotalAssets
    {
        [ForeignKey("BankName")]
        public int BankId { get; set; }

        public string BankName { get; set; }

        [ForeignKey("RiskRating")]
        public int Rating { get; set; }

        public long Assets { get; set; }

        public DateTime DateApplied { get; set; }
    }
}
