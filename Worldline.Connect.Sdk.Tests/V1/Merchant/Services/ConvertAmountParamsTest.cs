using NUnit.Framework;
using System.Collections.Generic;
using Worldline.Connect.Sdk.Communication;

namespace Worldline.Connect.Sdk.V1.Merchant.Services
{
    [TestFixture]
    public class ConvertAmountParamsTest
    {
        [TestCase]
        public void TestToRequestParameters()
        {
            var lParams = new ConvertAmountParams();
            var paramList = new List<RequestParam>();

            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.Amount = 1000L;
            paramList.Add(new RequestParam("amount", "1000"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.Source = "EUR";
            paramList.Add(new RequestParam("source", "EUR"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.Target = "USD";
            paramList.Add(new RequestParam("target", "USD"));
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));

            lParams.Amount = null;
            paramList.RemoveAt(0);
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(paramList));
        }
    }
}
