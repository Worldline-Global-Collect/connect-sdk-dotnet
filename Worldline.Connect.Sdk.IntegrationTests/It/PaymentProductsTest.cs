using NUnit.Framework;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Merchant.Products;

namespace Worldline.Connect.Sdk.It
{
    public class PaymentProductsTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for products service.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            var lParams = new FindProductsParams
            {
                CountryCode = "NL",
                CurrencyCode = "EUR"
            };

            using (var client = GetClient())
            {
                var response = await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Products
                    .Find(lParams);

                Assert.That(response.ListOfPaymentProducts, Is.Not.Empty);
            }
        }

        /// <summary>
        /// Smoke Test for product directories service.
        /// </summary>
        [TestCase]
        public async Task TestDirectories()
        {
            var lParams = new DirectoryParams
            {
                CountryCode = "NL",
                CurrencyCode = "EUR"
            };

            using (var client = GetClient())
            {
                var response = await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Products
                    .Directory(809, lParams);

                Assert.That(response.Entries, Is.Not.Empty);
            }
        }
    }
}
