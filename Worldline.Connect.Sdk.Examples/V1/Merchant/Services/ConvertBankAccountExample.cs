/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Services
{
    public static class ConvertBankAccountExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var bankAccountBban = new BankAccountBban();
                bankAccountBban.AccountNumber = "0532013000";
                bankAccountBban.BankCode = "37040044";
                bankAccountBban.CountryCode = "DE";

                var body = new BankDetailsRequest();
                body.BankAccountBban = bankAccountBban;

                var response = await client.V1.WithNewMerchant("merchantId").Services.Bankaccount(body);
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
