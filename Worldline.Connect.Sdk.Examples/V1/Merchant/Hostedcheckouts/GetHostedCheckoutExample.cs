/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Hostedcheckouts
{
    public class GetHostedCheckoutExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var response = await client.V1.WithNewMerchant("merchantId").Hostedcheckouts.Get("hostedCheckoutId");
            }
#pragma warning restore 0168
        }

        private static Client GetClient()
        {
            var apiKeyId = "someKey";
            var secretApiKey = "someSecret";

            var configuration = Factory.CreateConfiguration(apiKeyId, secretApiKey);
            return Factory.CreateClient(configuration);
        }
    }
}