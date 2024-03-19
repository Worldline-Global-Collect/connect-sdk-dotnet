using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Worldline.Connect.Sdk.Communication;

namespace Worldline.Connect.Sdk.V1.Merchant.Tokens
{
    [TestFixture]
    public class DeleteTokenParamsTest
    {
        [TestCase]
        public void TestToRequestParameters()
        {
            var lParams = new DeleteTokenParams();

            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(Enumerable.Empty<RequestParam>()));

            lParams.MandateCancelDate = "20160610";
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(new List<RequestParam>{ new RequestParam("mandateCancelDate", "20160610")}));

            lParams.MandateCancelDate = null;
            Assert.That(lParams.ToRequestParameters(), Is.EquivalentTo(Enumerable.Empty<RequestParam>()));
        }
    }
}
