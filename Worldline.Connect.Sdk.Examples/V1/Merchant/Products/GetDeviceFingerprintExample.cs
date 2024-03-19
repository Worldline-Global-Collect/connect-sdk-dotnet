/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Products
{
    public class GetDeviceFingerprintExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var body = new DeviceFingerprintRequest();

                var response = await client.V1.WithNewMerchant("merchantId").Products.DeviceFingerprint(1, body);
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
