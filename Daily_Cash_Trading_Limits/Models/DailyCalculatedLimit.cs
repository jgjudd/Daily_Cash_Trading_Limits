using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daily_Cash_Trading_Limits.Models
{
    [Table("DailyCalculatedLimits")]
    public class DailyCalculatedLimit
    {
        [Key]
        public int BankId { get; set; }        

        public long BaseLimit { get; set; }
    }
}
