/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Threading.Tasks;

namespace Worldline.Connect.Sdk.V1.Merchant.Products
{
    public static class GetNetworksExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var query = new NetworksParams();
                query.CountryCode = "US";
                query.CurrencyCode = "USD";
                query.Amount = 1000L;
                query.IsRecurring = true;

                var response = await client.V1.WithNewMerchant("merchantId").Products.Networks(320, query);
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
