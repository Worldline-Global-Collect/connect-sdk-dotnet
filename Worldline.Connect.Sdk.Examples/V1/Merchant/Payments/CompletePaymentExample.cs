/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Payments
{
    public class CompletePaymentExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var card = new CardWithoutCvv();
                card.CardNumber = "67030000000000003";
                card.CardholderName = "Wile E. Coyote";
                card.ExpiryDate = "1299";

                var cardPaymentMethodSpecificInput = new CompletePaymentCardPaymentMethodSpecificInput();
                cardPaymentMethodSpecificInput.Card = card;

                var body = new CompletePaymentRequest();
                body.CardPaymentMethodSpecificInput = cardPaymentMethodSpecificInput;

                var response = await client.V1.WithNewMerchant("merchantId").Payments.Complete("paymentId", body);
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
