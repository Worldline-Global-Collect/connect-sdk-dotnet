/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Merchant.Productgroups
{
    public class GetPaymentProductGroupExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var query = new GetProductgroupParams();
                query.CountryCode = "US";
                query.CurrencyCode = "USD";
                query.Locale = "en_US";
                query.Amount = 1000L;
                query.IsRecurring = true;
                query.IsInstallments = true;
                query.AddHide("fields");

                var response = await client.V1.WithNewMerchant("merchantId").Productgroups.Get("cards", query);
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
