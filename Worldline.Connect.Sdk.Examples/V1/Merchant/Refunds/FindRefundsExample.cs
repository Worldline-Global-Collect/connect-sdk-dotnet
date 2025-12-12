/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Threading.Tasks;

namespace Worldline.Connect.Sdk.V1.Merchant.Refunds
{
    public static class FindRefundsExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var query = new FindRefundsParams();
                query.HostedCheckoutId = "15c09dac-bf44-486a-af6b-edfd8680a166";
                query.MerchantReference = "AcmeOrder0001";
                query.MerchantOrderId = 123456L;
                query.Offset = 0;
                query.Limit = 10;

                var response = await client.V1.WithNewMerchant("merchantId").Refunds.Find(query);
            }
#pragma warning restore 0168
        }

        private static Client GetClient()
        {
            const string apiKeyId = "someKey";
            const string secretApiKey = "someSecret";

            var configuration = Factory.CreateConfiguration(apiKeyId, secretApiKey);
            return Factory.CreateClient(configuration);
        }
    }
}
