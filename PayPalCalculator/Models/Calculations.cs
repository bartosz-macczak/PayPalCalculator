using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayPalCalculator.Models
{
    public class Calculations
    {
        public static string YouAskFor(decimal ammount, Country country)
        {
            if (ammount == 0)
            {
                return "0";
            }

            ammount /= 1 - country.PercentFee;
            ammount += country.ConstFee;
            return ammount.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string YouReceive(decimal ammount, Country country)
        {
            if (ammount == 0)
            {
                return "0";
            }

            ammount -= ammount * country.PercentFee;
            ammount -= country.ConstFee;
            return ammount.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string GetCurrency(decimal ammount, Country country)
        {
            if (ammount == 0)
            {
                return "";
            }
            else
            {
                return country.Currency;
            }
        }
    }
}

