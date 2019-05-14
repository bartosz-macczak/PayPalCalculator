using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayPalCalculator.Models
{
    public class Country
    {
        public string CountryName { get; set; }
        public decimal PercentFee { get; set; }
        public decimal ConstFee { get; set; }
        public string Currency { get; set; }
    }
}
