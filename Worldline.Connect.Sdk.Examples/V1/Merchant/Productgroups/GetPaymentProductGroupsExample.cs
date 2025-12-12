/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Threading.Tasks;

namespace Worldline.Connect.Sdk.V1.Merchant.Productgroups
{
    public static class GetPaymentProductGroupsExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var query = new FindProductgroupsParams();
                query.CountryCode = "US";
                query.CurrencyCode = "USD";
                query.Locale = "en_US";
                query.Amount = 1000L;
                query.IsRecurring = true;
                query.IsInstallments = true;
                query.AddHide("fields");

                var response = await client.V1.WithNewMerchant("merchantId").Productgroups.Find(query);
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
