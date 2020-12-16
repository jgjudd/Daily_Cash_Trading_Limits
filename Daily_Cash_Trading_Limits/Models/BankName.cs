using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daily_Cash_Trading_Limits.Models
{
    [Table("BankNames")]
    public class BankName
    {
        [Key]
        public int BankId { get; set; }

        public string Name { get; set; }

        public bool Approved { get; set; }
    }
}
