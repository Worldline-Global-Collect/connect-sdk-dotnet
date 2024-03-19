/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Payments
{
    public class ApprovePaymentExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var directDebitPaymentMethodSpecificInput = new ApprovePaymentNonSepaDirectDebitPaymentMethodSpecificInput();
                directDebitPaymentMethodSpecificInput.DateCollect = "20150201";
                directDebitPaymentMethodSpecificInput.Token = "bfa8a7e4-4530-455a-858d-204ba2afb77e";

                var references = new OrderReferencesApprovePayment();
                references.MerchantReference = "AcmeOrder0001";

                var order = new OrderApprovePayment();
                order.References = references;

                var body = new ApprovePaymentRequest();
                body.Amount = 2980L;
                body.DirectDebitPaymentMethodSpecificInput = directDebitPaymentMethodSpecificInput;
                body.Order = order;

                var response = await client.V1.WithNewMerchant("merchantId").Payments.Approve("paymentId", body);
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
