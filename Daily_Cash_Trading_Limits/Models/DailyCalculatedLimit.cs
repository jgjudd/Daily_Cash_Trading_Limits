using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daily_Cash_Trading_Limits.Models
{
    [Table("DailyCalculatedLimit")]
    public class DailyCalculatedLimit
    {
        [ForeignKey("BankName")]
        public int BankId { get; set; }        

        public long Limit { get; set; }
    }
}
