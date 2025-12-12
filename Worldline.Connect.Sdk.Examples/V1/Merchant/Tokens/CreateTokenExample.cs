/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Tokens
{
    public static class CreateTokenExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var billingAddress = new Address();
                billingAddress.AdditionalInfo = "Suite II";
                billingAddress.City = "Monument Valley";
                billingAddress.CountryCode = "US";
                billingAddress.HouseNumber = "1";
                billingAddress.State = "Utah";
                billingAddress.Street = "Desertroad";
                billingAddress.Zip = "84536";

                var companyInformation = new CompanyInformation();
                companyInformation.Name = "Acme Labs";

                var name = new PersonalNameToken();
                name.FirstName = "Wile";
                name.Surname = "Coyote";
                name.SurnamePrefix = "E.";

                var personalInformation = new PersonalInformationToken();
                personalInformation.Name = name;

                var customer = new CustomerToken();
                customer.BillingAddress = billingAddress;
                customer.CompanyInformation = companyInformation;
                customer.MerchantCustomerId = "1234";
                customer.PersonalInformation = personalInformation;

                var bankAccountBban = new BankAccountBban();
                bankAccountBban.AccountNumber = "000000123456";
                bankAccountBban.BankCode = "05428";
                bankAccountBban.BranchCode = "11101";
                bankAccountBban.CheckDigit = "X";
                bankAccountBban.CountryCode = "IT";

                var paymentProduct705SpecificData = new TokenNonSepaDirectDebitPaymentProduct705SpecificData();
                paymentProduct705SpecificData.AuthorisationId = "123456";
                paymentProduct705SpecificData.BankAccountBban = bankAccountBban;

                var mandate = new MandateNonSepaDirectDebit();
                mandate.PaymentProduct705SpecificData = paymentProduct705SpecificData;

                var nonSepaDirectDebit = new TokenNonSepaDirectDebit();
                nonSepaDirectDebit.Customer = customer;
                nonSepaDirectDebit.Mandate = mandate;

                var body = new CreateTokenRequest();
                body.NonSepaDirectDebit = nonSepaDirectDebit;
                body.PaymentProductId = 705;

                var response = await client.V1.WithNewMerchant("merchantId").Tokens.Create(body);
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
