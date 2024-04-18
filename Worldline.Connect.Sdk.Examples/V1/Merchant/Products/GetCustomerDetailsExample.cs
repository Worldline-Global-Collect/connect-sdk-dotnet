/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.V1.Domain;
using KeyValuePair = Worldline.Connect.Sdk.V1.Domain.KeyValuePair;

namespace Worldline.Connect.Sdk.V1.Merchant.Products
{
    public class GetCustomerDetailsExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var values = new List<KeyValuePair>();

                var value1 = new KeyValuePair();
                value1.Key = "fiscalNumber";
                value1.Value = "01234567890";

                values.Add(value1);

                var body = new GetCustomerDetailsRequest();
                body.CountryCode = "SE";
                body.Values = values;

                var response = await client.V1.WithNewMerchant("merchantId").Products.CustomerDetails(9000, body);
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
