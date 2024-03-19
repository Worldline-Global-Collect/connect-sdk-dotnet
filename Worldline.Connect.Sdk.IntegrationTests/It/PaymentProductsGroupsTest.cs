using NUnit.Framework;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Merchant.Productgroups;

namespace Worldline.Connect.Sdk.It
{
    public class PaymentProductsGroupsTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for product groups service.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            var lParams = new GetProductgroupParams
            {
                CountryCode = "NL",
                CurrencyCode = "EUR"
            };

            using (var client = GetClient())
            {
                var response = await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Productgroups
                    .Get("cards", lParams);

                Assert.AreEqual("cards", response.Id);
            }
        }
    }
}
