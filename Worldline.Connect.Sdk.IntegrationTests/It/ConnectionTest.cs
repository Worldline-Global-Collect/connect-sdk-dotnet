using NUnit.Framework;
using System.Threading.Tasks;

namespace Worldline.Connect.Sdk.It
{
    [TestFixture]
    public class ConnectionTestTest : IntegrationTest
    {
        /// <summary>
        /// Smoke test for test connection.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            using (var client = GetClient())
            {
                await client.V1.WithNewMerchant(GetMerchantId()).Services.Testconnection();
            }
        }
    }
}
