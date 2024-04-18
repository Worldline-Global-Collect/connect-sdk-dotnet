/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;
using System.IO;
using System.Threading;

namespace Worldline.Connect.Sdk.V1.Merchant.Files
{
    public class GetFileExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                await client.V1.WithNewMerchant("merchantId").Files.GetFile("fileId", (stream, headers) => {
                    // Do something with stream and headers here.
                });

                // Note: no SynchronizationContext will be available inside the body handler.
                // Should your body handler need the current one, you need to capture it first:
                var sc = SynchronizationContext.Current;
                await client.V1.WithNewMerchant("merchantId").Files.GetFile("fileId", (stream, headers) => sc.Send(delegate {
                    // Do something with stream and headers here.
                }, null));
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
