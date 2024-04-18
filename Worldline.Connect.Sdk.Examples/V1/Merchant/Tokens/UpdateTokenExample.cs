/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Tokens
{
    public class UpdateTokenExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var billingAddress = new Address();
                billingAddress.AdditionalInfo = "b";
                billingAddress.City = "Monument Valley";
                billingAddress.CountryCode = "US";
                billingAddress.HouseNumber = "13";
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

                var cardWithoutCvv = new CardWithoutCvv();
                cardWithoutCvv.CardNumber = "4567350000427977";
                cardWithoutCvv.CardholderName = "Wile E. Coyote";
                cardWithoutCvv.ExpiryDate = "1299";
                cardWithoutCvv.IssueNumber = "12";

                var data = new TokenCardData();
                data.CardWithoutCvv = cardWithoutCvv;

                var card = new TokenCard();
                card.Customer = customer;
                card.Data = data;

                var body = new UpdateTokenRequest();
                body.Card = card;
                body.PaymentProductId = 1;

                await client.V1.WithNewMerchant("merchantId").Tokens.Update("tokenId", body);
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
