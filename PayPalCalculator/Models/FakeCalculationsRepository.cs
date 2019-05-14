using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayPalCalculator.Models
{
    public class FakeCalculationsRepository : ICalculationsRepository
    {
        public IQueryable<Country> Country => new List<Country>
        {
            new Country { CountryName = "Poland", ConstFee = 0.4M, PercentFee = 0.35M},
            new Country { CountryName = "Germany", ConstFee = 0.35M, PercentFee = 0.30M}
        }.AsQueryable<Country>();
    }
}
