/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Riskassessments
{
    public class RiskAssessmentBankAccountExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var bankAccountBban = new BankAccountBban();
                bankAccountBban.AccountNumber = "0532013000";
                bankAccountBban.BankCode = "37040044";
                bankAccountBban.CountryCode = "DE";

                var amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 100L;
                amountOfMoney.CurrencyCode = "EUR";

                var billingAddress = new Address();
                billingAddress.CountryCode = "US";

                var customer = new CustomerRiskAssessment();
                customer.BillingAddress = billingAddress;
                customer.Locale = "en_US";

                var order = new OrderRiskAssessment();
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;

                var body = new RiskAssessmentBankAccount();
                body.BankAccountBban = bankAccountBban;
                body.Order = order;

                var response = await client.V1.WithNewMerchant("merchantId").Riskassessments.Bankaccounts(body);
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
