using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CurrencyRatesWCF
{
    [ServiceContract]
    public interface IRatesService
    {

        [OperationContract]
        List<string> GetExchangeRates();

        [OperationContract]
        List<double> GetCurrencies(string currencyType);

    }



}
