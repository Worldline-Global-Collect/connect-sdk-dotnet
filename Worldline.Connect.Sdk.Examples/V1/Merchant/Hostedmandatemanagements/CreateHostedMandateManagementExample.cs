/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Hostedmandatemanagements
{
    public class CreateHostedMandateManagementExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var createMandateInfo = new HostedMandateInfo();
                createMandateInfo.CustomerReference = "idonthaveareference";
                createMandateInfo.RecurrenceType = "RECURRING";
                createMandateInfo.SignatureType = "UNSIGNED";

                var hostedMandateManagementSpecificInput = new HostedMandateManagementSpecificInput();
                hostedMandateManagementSpecificInput.Locale = "fr_FR";
                hostedMandateManagementSpecificInput.ReturnUrl = "http://www.example.com";
                hostedMandateManagementSpecificInput.Variant = "101";

                var body = new CreateHostedMandateManagementRequest();
                body.CreateMandateInfo = createMandateInfo;
                body.HostedMandateManagementSpecificInput = hostedMandateManagementSpecificInput;

                var response = await client.V1.WithNewMerchant("merchantId").Hostedmandatemanagements.Create(body);
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
