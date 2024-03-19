using NUnit.Framework;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Merchant.Services;

namespace Worldline.Connect.Sdk.It
{
    [TestFixture]
    public class SystemProxyTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for using a proxy configured through system properties.
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

            var configuration = GetCommunicatorConfiguration();

            using (var client = Factory.CreateClient(configuration))
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
