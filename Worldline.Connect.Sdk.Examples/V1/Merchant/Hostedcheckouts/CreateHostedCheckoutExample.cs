/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Hostedcheckouts
{
    public static class CreateHostedCheckoutExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var hostedCheckoutSpecificInput = new HostedCheckoutSpecificInput();
                hostedCheckoutSpecificInput.Locale = "en_GB";
                hostedCheckoutSpecificInput.Variant = "testVariant";

                var amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 2345L;
                amountOfMoney.CurrencyCode = "USD";

                var billingAddress = new Address();
                billingAddress.CountryCode = "US";

                var customer = new Customer();
                customer.BillingAddress = billingAddress;
                customer.MerchantCustomerId = "1234";

                var order = new Order();
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;

                var body = new CreateHostedCheckoutRequest();
                body.HostedCheckoutSpecificInput = hostedCheckoutSpecificInput;
                body.Order = order;

                var response = await client.V1.WithNewMerchant("merchantId").Hostedcheckouts.Create(body);
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
