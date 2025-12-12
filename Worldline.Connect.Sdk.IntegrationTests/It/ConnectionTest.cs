using NUnit.Framework;

namespace Worldline.Connect.Sdk.It
{
    [TestFixture]
    public class ConnectionTestTest : IntegrationTest
    {
        /// <summary>
        /// Smoke test for test connection.
        /// </summary>
        [TestCase]
        public void Test()
        {
            using (var client = GetClient())
            {
                Assert.DoesNotThrowAsync(async () => await client.V1.WithNewMerchant(GetMerchantId()).Services.Testconnection());
            }
        }
    }
}
