/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Merchant.Services
{
    public class GetPrivacyPolicyExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var query = new PrivacypolicyParams();
                query.Locale = "en_US";
                query.PaymentProductId = 771;

                var response = await client.V1.WithNewMerchant("merchantId").Services.Privacypolicy(query);
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
