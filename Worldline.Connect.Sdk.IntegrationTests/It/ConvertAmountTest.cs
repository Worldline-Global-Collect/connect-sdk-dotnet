using NUnit.Framework;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Merchant.Services;

namespace Worldline.Connect.Sdk.It
{
    [TestFixture]
    public class ConvertAmountTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for convert amount service.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            var request = new ConvertAmountParams
            {
                Amount = 123L,
                Source = "USD",
                Target = "EUR"
            };

            using (var client = GetClient())
            {
                var response = await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Services
                    .ConvertAmount(request);

                Assert.NotNull(response.ConvertedAmount);
            }
        }
    }
}
