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
    public static class CreatePaymentExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var card = new Card();
                card.CardNumber = "4567350000427977";
                card.CardholderName = "Wile E. Coyote";
                card.Cvv = "123";
                card.ExpiryDate = "1299";

                var authenticationAmount = new AmountOfMoney();
                authenticationAmount.Amount = 2980L;
                authenticationAmount.CurrencyCode = "EUR";

                var redirectionData = new RedirectionData();
                redirectionData.ReturnUrl = "https://hostname.myownwebsite.url";

                var threeDSecure = new ThreeDSecure();
                threeDSecure.AuthenticationAmount = authenticationAmount;
                threeDSecure.AuthenticationFlow = "browser";
                threeDSecure.ChallengeCanvasSize = "600x400";
                threeDSecure.ChallengeIndicator = "challenge-requested";
                threeDSecure.ExemptionRequest = "none";
                threeDSecure.RedirectionData = redirectionData;
                threeDSecure.SkipAuthentication = false;

                var cardPaymentMethodSpecificInput = new CardPaymentMethodSpecificInput();
                cardPaymentMethodSpecificInput.Card = card;
                cardPaymentMethodSpecificInput.IsRecurring = false;
                cardPaymentMethodSpecificInput.MerchantInitiatedReasonIndicator = "delayedCharges";
                cardPaymentMethodSpecificInput.PaymentProductId = 1;
                cardPaymentMethodSpecificInput.ThreeDSecure = threeDSecure;
                cardPaymentMethodSpecificInput.TransactionChannel = "ECOMMERCE";

                var amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 2980L;
                amountOfMoney.CurrencyCode = "EUR";

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
                companyInformation.VatNumber = "1234AB5678CD";

                var contactDetails = new ContactDetails();
                contactDetails.EmailAddress = "wile.e.coyote@acmelabs.com";
                contactDetails.FaxNumber = "+1234567891";
                contactDetails.PhoneNumber = "+1234567890";

                var browserData = new BrowserData();
                browserData.ColorDepth = 24;
                browserData.JavaEnabled = false;
                browserData.ScreenHeight = "1200";
                browserData.ScreenWidth = "1920";

                var device = new CustomerDevice();
                device.AcceptHeader = "texthtml,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                device.BrowserData = browserData;
                device.IpAddress = "123.123.123.123";
                device.Locale = "en-US";
                device.TimezoneOffsetUtcMinutes = "420";
                device.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_4) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1 Safari/605.1.15";

                var name = new PersonalName();
                name.FirstName = "Wile";
                name.Surname = "Coyote";
                name.SurnamePrefix = "E.";
                name.Title = "Mr.";

                var personalInformation = new PersonalInformation();
                personalInformation.DateOfBirth = "19490917";
                personalInformation.Gender = "male";
                personalInformation.Name = name;

                var customer = new Customer();
                customer.AccountType = "none";
                customer.BillingAddress = billingAddress;
                customer.CompanyInformation = companyInformation;
                customer.ContactDetails = contactDetails;
                customer.Device = device;
                customer.Locale = "en_US";
                customer.MerchantCustomerId = "1234";
                customer.PersonalInformation = personalInformation;

                var invoiceData = new OrderInvoiceData();
                invoiceData.InvoiceDate = "20140306191500";
                invoiceData.InvoiceNumber = "000000123";

                var references = new OrderReferences();
                references.Descriptor = "Fast and Furry-ous";
                references.InvoiceData = invoiceData;
                references.MerchantOrderId = 123456L;
                references.MerchantReference = "AcmeOrder0001";

                var shippingName = new PersonalName();
                shippingName.FirstName = "Road";
                shippingName.Surname = "Runner";
                shippingName.Title = "Miss";

                var address = new AddressPersonal();
                address.AdditionalInfo = "Suite II";
                address.City = "Monument Valley";
                address.CountryCode = "US";
                address.HouseNumber = "1";
                address.Name = shippingName;
                address.State = "Utah";
                address.Street = "Desertroad";
                address.Zip = "84536";

                var shipping = new Shipping();
                shipping.Address = address;

                var items = new List<LineItem>();

                var item1AmountOfMoney = new AmountOfMoney();
                item1AmountOfMoney.Amount = 2500L;
                item1AmountOfMoney.CurrencyCode = "EUR";

                var item1InvoiceData = new LineItemInvoiceData();
                item1InvoiceData.Description = "ACME Super Outfit";
                item1InvoiceData.NrOfItems = "1";
                item1InvoiceData.PricePerItem = 2500L;

                var item1 = new LineItem();
                item1.AmountOfMoney = item1AmountOfMoney;
                item1.InvoiceData = item1InvoiceData;

                items.Add(item1);

                var item2AmountOfMoney = new AmountOfMoney();
                item2AmountOfMoney.Amount = 480L;
                item2AmountOfMoney.CurrencyCode = "EUR";

                var item2InvoiceData = new LineItemInvoiceData();
                item2InvoiceData.Description = "Aspirin";
                item2InvoiceData.NrOfItems = "12";
                item2InvoiceData.PricePerItem = 40L;

                var item2 = new LineItem();
                item2.AmountOfMoney = item2AmountOfMoney;
                item2.InvoiceData = item2InvoiceData;

                items.Add(item2);

                var shoppingCart = new ShoppingCart();
                shoppingCart.Items = items;

                var order = new Order();
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;
                order.References = references;
                order.Shipping = shipping;
                order.ShoppingCart = shoppingCart;

                var body = new CreatePaymentRequest();
                body.CardPaymentMethodSpecificInput = cardPaymentMethodSpecificInput;
                body.Order = order;

                try
                {
                    var response = await client.V1.WithNewMerchant("merchantId").Payments.Create(body);
                }
                catch (DeclinedPaymentException e)
                {
                    HandleDeclinedPayment(e.CreatePaymentResult);
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

        private static void HandleDeclinedPayment(CreatePaymentResult createPaymentResult)
        {
            // handle the result here
        }

        private static void HandleErrorResponse(string errorId, IList<APIError> errors)
        {
            // handle the error response here
        }
    }
}
