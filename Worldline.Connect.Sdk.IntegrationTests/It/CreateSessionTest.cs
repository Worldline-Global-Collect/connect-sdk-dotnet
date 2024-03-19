using NUnit.Framework;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.It
{
    public class CreateSessionTest : IntegrationTest
    {
        /**
         * Smoke Test for products service.
         */
        [TestCase]
        public async Task Test()
        {
            var lParams = new SessionRequest();

            using (var client = GetClient())
            {
                await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Sessions
                    .Create(lParams);
            }
        }
    }
}
