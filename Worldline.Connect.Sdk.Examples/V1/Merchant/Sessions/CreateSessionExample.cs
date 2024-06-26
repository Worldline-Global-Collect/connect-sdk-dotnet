/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Sessions
{
    public class CreateSessionExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var tokens = new List<string>();
                tokens.Add("126166b16ed04b3ab85fb06da1d7a167");
                tokens.Add("226166b16ed04b3ab85fb06da1d7a167");
                tokens.Add("122c5b4d-dd40-49f0-b7c9-3594212167a9");
                tokens.Add("326166b16ed04b3ab85fb06da1d7a167");
                tokens.Add("426166b16ed04b3ab85fb06da1d7a167");

                var body = new SessionRequest();
                body.Tokens = tokens;

                var response = await client.V1.WithNewMerchant("merchantId").Sessions.Create(body);
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
