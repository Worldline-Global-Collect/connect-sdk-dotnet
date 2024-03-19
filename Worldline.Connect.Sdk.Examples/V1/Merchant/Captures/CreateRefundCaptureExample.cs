/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.V1;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Captures
{
    public class CreateRefundCaptureExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 500L;
                amountOfMoney.CurrencyCode = "EUR";

                var refundReferences = new RefundReferences();
                refundReferences.MerchantReference = "AcmeOrder0001";

                var body = new RefundRequest();
                body.AmountOfMoney = amountOfMoney;
                body.RefundReferences = refundReferences;

                try
                {
                    var response = await client.V1.WithNewMerchant("merchantId").Captures.Refund("captureId", body);
                }
                catch (DeclinedRefundException e)
                {
                    HandleDeclinedRefund(e.RefundResult);
                }
                catch (ApiException e)
                {
                    HandleApiErrors(e.Errors);
                }
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

        private static void HandleDeclinedRefund(RefundResult refundResult)
        {
            // handle the result here
        }

        private static void HandleApiErrors(IList<APIError> errors)
        {
            // handle the errors here
        }
    }
}
