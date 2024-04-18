/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.IO;
using Worldline.Connect.Sdk.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Disputes
{
    public class UploadDisputeFileExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var body = new UploadFileRequest();
                using (var fileContent = File.OpenRead("file.pdf"))
                {
                    body.File = new UploadableFile("file.pdf", fileContent, "application/pdf");

                    var response = await client.V1.WithNewMerchant("merchantId").Disputes.UploadFile("disputeId", body);
                }
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
