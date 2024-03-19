using NUnit.Framework;
using System;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.It
{
    public class IdemPotenceTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for idempotence.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            var amountOfMoney = new AmountOfMoney
            {
                CurrencyCode = "EUR",
                Amount = 100L
            };

            var billingAddress = new Address
            {
                CountryCode = "NL"
            };

            var customer = new Customer
            {
                Locale = "en",
                BillingAddress = billingAddress
            };

            var order = new Order
            {
                AmountOfMoney = amountOfMoney,
                Customer = customer
            };

            var redirectionData = new RedirectionData
            {
                ReturnUrl = "http://example.com/"
            };

            var paymentProductSpecificInput = new RedirectPaymentProduct809SpecificInput
            {
                IssuerId = "INGBNL2A"
            };

            var paymentMethodSpecificInput = new RedirectPaymentMethodSpecificInput
            {
                RedirectionData = redirectionData,
                PaymentProductId = 809,
                PaymentProduct809SpecificInput = paymentProductSpecificInput
            };

            var body = new CreatePaymentRequest
            {
                Order = order,
                RedirectPaymentMethodSpecificInput = paymentMethodSpecificInput
            };

            var idempotenceKey = Guid.NewGuid().ToString();
            var context = new CallContext().WithIdempotenceKey(idempotenceKey);

            using (var client = GetClient())
            {
                var result = await DoCreatePayment(client, body, context);
                var paymentId = result.Payment.Id;
                var status = result.Payment.Status;

                Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
                Assert.Null(context.IdempotenceRequestTimestamp);

                result = await DoCreatePayment(client, body, context);

                Assert.AreEqual(paymentId, result.Payment.Id);
                Assert.AreEqual(status, result.Payment.Status);

                Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
                Assert.NotNull(context.IdempotenceRequestTimestamp);
            }
        }

        private static async Task<CreatePaymentResult> DoCreatePayment(Client client, CreatePaymentRequest body, CallContext context) {
            // For this test it doesn't matter if the response is successful or declined,
            // as long as idempotence is handled correctly
            try
            {
                return await client.V1.WithNewMerchant(GetMerchantId()).Payments.Create(body, context);
            } catch (DeclinedPaymentException e) {
                return e.CreatePaymentResult;
            }
        }
    }
}
