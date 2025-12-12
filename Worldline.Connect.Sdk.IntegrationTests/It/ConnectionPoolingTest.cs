using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Merchant.Services;

namespace Worldline.Connect.Sdk.It
{
    public class ConnectionPoolingTest : IntegrationTest
    {
        [TestCase(10, 10)]
        [TestCase(10, 5)]
        [TestCase(10, 1)]
        public void TestConnectionPooling(int requestCount, int maxConnections)
        {
            var configuration = GetCommunicatorConfiguration().WithMaxConnections(maxConnections);
            using (var communicator = Factory.CreateCommunicator(configuration))
            {
                Assert.DoesNotThrowAsync(async () => await ActuallyTestConnectionPooling(communicator, requestCount));
            }
        }

        private static async Task ActuallyTestConnectionPooling(Communicator communicator, int requestCount)
        {
            await Task.WhenAll(Enumerable.Range(0, requestCount)
                               .Select(requestNum =>
                                          Factory.CreateClient(communicator)
                                          .WithClientMetaInfo("")
                                          .V1
                                          .WithNewMerchant(GetMerchantId())
                                          .Services
                                          .ConvertAmount(
                                              new ConvertAmountParams
                                              {
                                                  Source = "USD",
                                                  Target = "EUR",
                                                  Amount = 100L * (requestNum + 1)
                                              }
                                         )
                                     ).ToList()
                              );
        }
    }
}
