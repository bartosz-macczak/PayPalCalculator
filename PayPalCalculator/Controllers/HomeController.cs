using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayPalCalculator.Models;

namespace PayPalCalculator.Controllers
{
    public class HomeController : Controller
    {
        //private ICalculationsRepository repository = new FakeCalculationsRepository();

        //HomeController(ICalculationsRepository repo)
        //{
        //    this.repository = repo;
        //}


        List<Country> countryArray = new List<Country>()
        {
            new Country{ CountryName = "UK", ConstFee = 0.3M, PercentFee = 0.034M, Currency = "£"},
            new Country{ CountryName = "Europe", ConstFee = 0.35M, PercentFee = 0.034M, Currency = "€"},
            new Country{ CountryName = "France", ConstFee = 0.25M, PercentFee = 0.034M, Currency = "€"},

            new Country{ CountryName = "Germany", ConstFee = 0.3M, PercentFee = 0.029M, Currency = "PLN"},
            new Country{ CountryName = "Australia", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "New Zeland", ConstFee = 0.3M, PercentFee = 0.029M, Currency = "PLN"},
            new Country{ CountryName = "Czech Republic", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "Hungary", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "Poland", ConstFee = 0.3M, PercentFee = 0.029M, Currency = "PLN"},
            new Country{ CountryName = "Dennmark", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "Norway", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "Sweden", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "Switzerland", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "Singapore", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "Honk Kong", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "Japan", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "Kanada", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"},
            new Country{ CountryName = "USA", ConstFee = 0.3M, PercentFee = 0.04M, Currency = "EUR"}


        };

        public ViewResult Index(decimal ammount, string country)
        {
            Country SelectedCountry = countryArray.Where(p => p.CountryName == country).FirstOrDefault();
            ViewBag.YouReceive = Calculations.YouReceive(ammount, SelectedCountry);
            ViewBag.YouAskFor = Calculations.YouAskFor(ammount, SelectedCountry);
            ViewBag.CurrencyName = Calculations.GetCurrency(ammount, SelectedCountry);

            ViewBag.ammount = ammount;
            ViewBag.countryArray = countryArray;
            return View("Index");
        }

        public ViewResult PasswordGenerator()
        {


            return View();
        }
    }
}