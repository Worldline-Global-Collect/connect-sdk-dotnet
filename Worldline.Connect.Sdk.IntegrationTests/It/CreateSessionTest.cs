using NUnit.Framework;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.It
{
    public class CreateSessionTest : IntegrationTest
    {
        /**
         * Smoke Test for products service.
         */
        [TestCase]
        public void Test()
        {
            var lParams = new SessionRequest();

            using (var client = GetClient())
            {
                Assert.DoesNotThrowAsync(async () => await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Sessions
                    .Create(lParams));
            }
        }
    }
}
