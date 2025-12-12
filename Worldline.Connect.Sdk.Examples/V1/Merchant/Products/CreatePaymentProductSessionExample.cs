/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Products
{
    public static class CreatePaymentProductSessionExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var paymentProductSession302SpecificInput = new MobilePaymentProductSession302SpecificInput();
                paymentProductSession302SpecificInput.DisplayName = "Worldline";
                paymentProductSession302SpecificInput.DomainName = "pay1.checkout.worldline-solutions.com";
                paymentProductSession302SpecificInput.ValidationUrl = "<VALIDATION URL RECEIVED FROM APPLE>";

                var body = new CreatePaymentProductSessionRequest();
                body.PaymentProductSession302SpecificInput = paymentProductSession302SpecificInput;

                var response = await client.V1.WithNewMerchant("merchantId").Products.Sessions(302, body);
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
