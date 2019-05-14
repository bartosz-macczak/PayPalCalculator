using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayPalCalculator.Models
{
    public interface ICalculationsRepository
    {
        IQueryable<Country> Country { get; }
    }
}
