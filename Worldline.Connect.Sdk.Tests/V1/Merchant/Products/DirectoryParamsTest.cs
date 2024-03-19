using NUnit.Framework;
using System.Collections.Generic;
using Worldline.Connect.Sdk.Communication;

namespace Worldline.Connect.Sdk.V1.Merchant.Products
{
    [TestFixture]
    public class DirectoryParamsTest
    {
        [TestCase]
        public void TestToRequestParameters()
        {
            var lParams = new DirectoryParams();
            var paramList = new List<RequestParam>();

            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.CountryCode = "NL";
            paramList.Add(new RequestParam("countryCode", "NL"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.CurrencyCode = "EUR";
            paramList.Add(new RequestParam("currencyCode", "EUR"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));
        }
    }
}
