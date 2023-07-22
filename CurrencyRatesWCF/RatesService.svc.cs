using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CurrencyRatesWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RatesService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RatesService.svc or RatesService.svc.cs at the Solution Explorer and start debugging.
    public class RatesService : IRatesService
    {
        public List<double> GetCurrencies(string currencyType)
        {
            Random randomCurrency = new Random();
            List<double> ratesList = new List<double>();
            for (int i = 0; i < 15; i++)
            {
                ratesList.Add(randomCurrency.NextDouble() + 2);
            }
            return ratesList;

        }

        public List<string> GetExchangeRates()
        {
            List<string> rates = new List<string>();
            rates.Add("TL");
            rates.Add("Dolar");
            rates.Add("Euro");
            rates.Add("Pound");

            return rates;
        }
    }
}
