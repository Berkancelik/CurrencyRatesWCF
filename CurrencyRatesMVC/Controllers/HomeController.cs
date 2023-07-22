using CurrencyRatesMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyRatesMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (RatesServiceClient ratesServiceClient = new RatesServiceClient())
            {
                var model = ratesServiceClient.GetExchangeRatesAsync().ToString();

                return View(model);

            }
        }

 
    }
}
