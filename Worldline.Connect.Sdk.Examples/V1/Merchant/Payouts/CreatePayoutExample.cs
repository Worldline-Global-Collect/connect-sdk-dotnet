/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.V1;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Payouts
{
    public class CreatePayoutExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var bankAccountIban = new BankAccountIban();
                bankAccountIban.AccountHolderName = "Wile E. Coyote";
                bankAccountIban.Iban = "IT60X0542811101000000123456";

                var bankTransferPayoutMethodSpecificInput = new BankTransferPayoutMethodSpecificInput();
                bankTransferPayoutMethodSpecificInput.BankAccountIban = bankAccountIban;
                bankTransferPayoutMethodSpecificInput.PayoutDate = "20150102";
                bankTransferPayoutMethodSpecificInput.PayoutText = "Payout Acme";
                bankTransferPayoutMethodSpecificInput.SwiftCode = "swift";

                var amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 2345L;
                amountOfMoney.CurrencyCode = "EUR";

                var address = new Address();
                address.City = "Burbank";
                address.CountryCode = "US";
                address.HouseNumber = "411";
                address.State = "California";
                address.Street = "N Hollywood Way";
                address.Zip = "91505";

                var companyInformation = new CompanyInformation();
                companyInformation.Name = "Acme Labs";

                var contactDetails = new ContactDetailsBase();
                contactDetails.EmailAddress = "wile.e.coyote@acmelabs.com";

                var name = new PersonalName();
                name.FirstName = "Wile";
                name.Surname = "Coyote";
                name.SurnamePrefix = "E.";
                name.Title = "Mr.";

                var customer = new PayoutCustomer();
                customer.Address = address;
                customer.CompanyInformation = companyInformation;
                customer.ContactDetails = contactDetails;
                customer.Name = name;

                var references = new PayoutReferences();
                references.MerchantReference = "AcmeOrder001";

                var payoutDetails = new PayoutDetails();
                payoutDetails.AmountOfMoney = amountOfMoney;
                payoutDetails.Customer = customer;
                payoutDetails.References = references;

                var body = new CreatePayoutRequest();
                body.BankTransferPayoutMethodSpecificInput = bankTransferPayoutMethodSpecificInput;
                body.PayoutDetails = payoutDetails;

                try
                {
                    var response = await client.V1.WithNewMerchant("merchantId").Payouts.Create(body);
                }
                catch (DeclinedPayoutException e)
                {
                    HandleDeclinedPayout(e.PayoutResult);
                }
                catch (ApiException e)
                {
                    HandleErrorResponse(e.ErrorId, e.Errors);
                }
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

        private static void HandleDeclinedPayout(PayoutResult payoutResult)
        {
            // handle the result here
        }

        private static void HandleErrorResponse(string errorId, IList<APIError> errors)
        {
            // handle the error response here
        }
    }
}
