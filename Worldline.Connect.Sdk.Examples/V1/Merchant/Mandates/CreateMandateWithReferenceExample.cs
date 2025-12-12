/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Mandates
{
    public static class CreateMandateWithReferenceExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var bankAccountIban = new BankAccountIban();
                bankAccountIban.Iban = "DE46720200700359736690";

                var contactDetails = new MandateContactDetails();
                contactDetails.EmailAddress = "wile.e.coyote@acmelabs.com";

                var mandateAddress = new MandateAddress();
                mandateAddress.City = "Monumentenvallei";
                mandateAddress.CountryCode = "NL";
                mandateAddress.Street = "Woestijnweg";
                mandateAddress.Zip = "1337XD";

                var name = new MandatePersonalName();
                name.FirstName = "Wile";
                name.Surname = "Coyote";

                var personalInformation = new MandatePersonalInformation();
                personalInformation.Name = name;
                personalInformation.Title = "Miss";

                var customer = new MandateCustomer();
                customer.BankAccountIban = bankAccountIban;
                customer.CompanyName = "Acme labs";
                customer.ContactDetails = contactDetails;
                customer.MandateAddress = mandateAddress;
                customer.PersonalInformation = personalInformation;

                var body = new CreateMandateRequest();
                body.Customer = customer;
                body.CustomerReference = "idonthaveareference";
                body.Language = "nl";
                body.RecurrenceType = "UNIQUE";
                body.SignatureType = "UNSIGNED";

                var response = await client.V1.WithNewMerchant("merchantId").Mandates.CreateWithMandateReference("42268d8067df43e18a50a2ebf4bdb729", body);
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
