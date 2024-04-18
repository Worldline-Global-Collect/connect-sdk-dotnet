/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Merchant.Payments
{
    public class ProcessChallengedPaymentExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var response = await client.V1.WithNewMerchant("merchantId").Payments.Processchallenged("paymentId");
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
