/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Payments
{
    public class CreatePaymentDisputeExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 1234L;
                amountOfMoney.CurrencyCode = "USD";

                var body = new CreateDisputeRequest();
                body.AmountOfMoney = amountOfMoney;
                body.ContactPerson = "Wile Coyote";
                body.EmailAddress = "wile.e.coyote@acmelabs.com";
                body.ReplyTo = "r.runner@acmelabs.com";
                body.RequestMessage = "This is the message from the merchant to GlobalCollect. It is a a freeform text field.";

                var response = await client.V1.WithNewMerchant("merchantId").Payments.Dispute("paymentId", body);
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
