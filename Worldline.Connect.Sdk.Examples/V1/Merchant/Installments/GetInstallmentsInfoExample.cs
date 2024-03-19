/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Installments
{
    public class GetInstallmentsInfoExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 123L;
                amountOfMoney.CurrencyCode = "EUR";

                var body = new GetInstallmentRequest();
                body.AmountOfMoney = amountOfMoney;
                body.Bin = "123455";
                body.CountryCode = "NL";
                body.PaymentProductId = 123;

                var response = await client.V1.WithNewMerchant("merchantId").Installments.GetInstallmentsInfo(body);
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
