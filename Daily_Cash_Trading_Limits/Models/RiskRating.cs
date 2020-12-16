using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daily_Cash_Trading_Limits.Models
{
    [Table("RiskRating")]
    public class RiskRating
    {
        [Key]
        public int Rating { get; set; }

        public double EffectOnLimit { get; set; }
    }
}
