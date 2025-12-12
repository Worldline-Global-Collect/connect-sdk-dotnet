/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Payments
{
    public static class RefundPaymentExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 1L;
                amountOfMoney.CurrencyCode = "EUR";

                var bankAccountIban = new BankAccountIban();
                bankAccountIban.Iban = "NL53INGB0000000036";

                var bankRefundMethodSpecificInput = new BankRefundMethodSpecificInput();
                bankRefundMethodSpecificInput.BankAccountIban = bankAccountIban;

                var name = new PersonalName();
                name.Surname = "Coyote";

                var address = new AddressPersonal();
                address.CountryCode = "US";
                address.Name = name;

                var contactDetails = new ContactDetailsBase();
                contactDetails.EmailAddress = "wile.e.coyote@acmelabs.com";
                contactDetails.EmailMessageType = "html";

                var customer = new RefundCustomer();
                customer.Address = address;
                customer.ContactDetails = contactDetails;

                var refundReferences = new RefundReferences();
                refundReferences.MerchantReference = "AcmeOrder0001";

                var body = new RefundRequest();
                body.AmountOfMoney = amountOfMoney;
                body.BankRefundMethodSpecificInput = bankRefundMethodSpecificInput;
                body.Customer = customer;
                body.RefundDate = "20140306";
                body.RefundReferences = refundReferences;

                try
                {
                    var response = await client.V1.WithNewMerchant("merchantId").Payments.Refund("paymentId", body);
                }
                catch (DeclinedRefundException e)
                {
                    HandleDeclinedRefund(e.RefundResult);
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

        private static void HandleDeclinedRefund(RefundResult refundResult)
        {
            // handle the result here
        }

        private static void HandleErrorResponse(string errorId, IList<APIError> errors)
        {
            // handle the error response here
        }
    }
}
