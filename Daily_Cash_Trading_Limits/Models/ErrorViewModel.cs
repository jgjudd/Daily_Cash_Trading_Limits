using System;
using System.ComponentModel.DataAnnotations;

namespace Daily_Cash_Trading_Limits.Models
{
    public class ErrorViewModel
    {
        [Key]
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
