using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MockHttpServer;
using NUnit.Framework;
using Worldline.Connect.Sdk.Authentication;
using Worldline.Connect.Sdk.V1;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.Communication
{
    [TestFixture]
    public class DefaultConnectionIdempotenceTest
    {
        private const int Port = 5357;

        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private const string IdempotenceSuccessJson = @"{
    ""creationOutput"": {
        ""additionalReference"": ""00000200002014254946"",
        ""externalReference"": ""000002000020142549460000100001""
    },
    ""payment"": {
        ""id"": ""000002000020142549460000100001"",
        ""paymentOutput"": {
            ""amountOfMoney"": {
                ""amount"": 2345,
                ""currencyCode"": ""CAD""
            },
            ""references"": {
                ""paymentReference"": ""0""
            },
            ""paymentMethod"": ""card"",
            ""cardPaymentMethodSpecificOutput"": {
                ""paymentProductId"": 1,
                ""authorisationCode"": ""OK1131"",
                ""card"": {
                    ""cardNumber"": ""************9176"",
                    ""expiryDate"": ""1220""
                },
                ""fraudResults"": {
                    ""fraudServiceResult"": ""error"",
                    ""avsResult"": ""X"",
                    ""cvvResult"": ""M""
                }
            }
        },
        ""status"": ""PENDING_APPROVAL"",
        ""statusOutput"": {
            ""isCancellable"": true,
            ""statusCode"": 600,
            ""statusCodeChangeDateTime"": ""20150331120036"",
            ""isAuthorized"": true
        }
    }
}";
        private const string IdempotenceRejectedJson = @"{
    ""errorId"": ""2c164323-20d3-4e9e-8578-dc562cd7506c-0000003c"",
    ""errors"": [
        {
            ""code"": ""21000020"",
            ""requestId"": ""2001798"",
            ""message"": ""VALUE **************** OF FIELD CREDITCARDNUMBER DID NOT PASS THE LUHNCHECK""
        }
    ],
    ""paymentResult"": {
        ""creationOutput"": {
            ""additionalReference"": ""00000200002014254436"",
            ""externalReference"": ""000002000020142544360000100001""
        },
        ""payment"": {
            ""id"": ""000002000020142544360000100001"",
            ""paymentOutput"": {
                ""amountOfMoney"": {
                    ""amount"": 2345,
                    ""currencyCode"": ""CAD""
                },
                ""references"": {
                    ""paymentReference"": ""0""
                },
                ""paymentMethod"": ""card"",
                ""cardPaymentMethodSpecificOutput"": {
                    ""paymentProductId"": 1
                }
            },
            ""status"": ""REJECTED"",
            ""statusOutput"": {
                ""errors"": [
                    {
                        ""code"": ""21000020"",
                        ""requestId"": ""2001798"",
                        ""message"": ""VALUE **************** OF FIELD CREDITCARDNUMBER DID NOT PASS THE LUHNCHECK""
                    }
                ],
                ""isCancellable"": false,
                ""statusCode"": 100,
                ""statusCodeChangeDateTime"": ""20150330173151"",
                ""isAuthorized"": false
            }
        }
    }
}";
        private const string IdempotenceDuplicateFailureJson = @"{
   ""errorId"" : ""75b0f13a-04a5-41b3-83b8-b295ddb23439-000013c6"",
   ""errors"" : [ {
      ""code"" : ""1409"",
      ""message"" : ""DUPLICATE REQUEST IN PROGRESS"",
      ""httpStatusCode"" : 409
   } ]
}";

        private static Client CreateClient()
        {
            var connection = new DefaultConnection(TimeSpan.FromMilliseconds(500000000), 500);
            var authenticator = new V1HMACAuthenticator("apiKey", "secret");
            var metadataProvider = new MetadataProvider("Worldline");
            var uriBuilder = new UriBuilder("http", "localhost")
            {
                Port = Port
            };
            var communicator = Factory.CreateCommunicator(uriBuilder.Uri, connection, authenticator, metadataProvider);
            return Factory.CreateClient(communicator);
        }

        private static CreatePaymentRequest CreateRequest()
        {
            var amountOfMoney = new AmountOfMoney
            {
                Amount = 2345L,
                CurrencyCode = "CAD"
            };

            var billingAddress = new Address
            {
                CountryCode = "CA"
            };

            var customer = new Customer
            {
                BillingAddress = billingAddress
            };

            var order = new Order
            {
                AmountOfMoney = amountOfMoney,
                Customer = customer
            };

            var card = new Card
            {
                Cvv = "123",
                CardNumber = "4567350000427977",
                ExpiryDate = "1220"
            };

            var cardPaymentMethodSpecificInput = new CardPaymentMethodSpecificInput
            {
                PaymentProductId = 1,
                Card = card
            };

            var body = new CreatePaymentRequest
            {
                CardPaymentMethodSpecificInput = cardPaymentMethodSpecificInput,
                Order = order
            };

            return body;
        }

        [TestCase]
        public async Task TestIdempotenceFirstRequest()
        {
            var body = IdempotenceSuccessJson;
            var idempotenceKey = Guid.NewGuid().ToString();

            var responseHeaders = new Dictionary<string, string>(1)
            {
                { "Location", "http://localhost/v1/20000/payments/000002000020142549460000100001" }
            };

            var requestHeaders = new Dictionary<string, string>();

            var context = new CallContext().WithIdempotenceKey(idempotenceKey);
            using (var _ = new MockServer(Port, "/v1/20000/payments", (request, response, arg3) =>
                   {
                       RecordRequest((HttpStatusCode)201, request, requestHeaders, response, responseHeaders);
                       return body;
                   }))
            using (var client = CreateClient())
            {
                var request = CreateRequest();

                var response = await client.V1.WithNewMerchant("20000").Payments.Create(request, context);

                Assert.NotNull(response);
                Assert.NotNull(response.Payment);
                Assert.NotNull(response.Payment.Id);
            }
            Assert.AreEqual(idempotenceKey, requestHeaders["X-GCS-Idempotence-Key"]);

            Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
            Assert.Null(context.IdempotenceRequestTimestamp);
        }

        [TestCase]
        public async Task TestIdempotenceSecondRequest()
        {
            var body = IdempotenceSuccessJson;
            var idempotenceKey = Guid.NewGuid().ToString();
            var idempotenceRequestTimestamp = (DateTime.UtcNow - Epoch).TotalMilliseconds;

            var responseHeaders = new Dictionary<string, string>(1)
            {
                { "Location", "http://localhost/v1/20000/payments/000002000020142549460000100001" },
                { "X-GCS-Idempotence-Request-Timestamp", idempotenceRequestTimestamp.ToString() }
            };

            var requestHeaders = new Dictionary<string, string>();

            var context = new CallContext().WithIdempotenceKey(idempotenceKey);
            using (var _ = new MockServer(Port, "/v1/20000/payments", (request, response, arg3) =>
            {
                RecordRequest((HttpStatusCode)201, request, requestHeaders, response, responseHeaders);
                return body;
            }))
            using (var client = CreateClient())
            {
                var request = CreateRequest();

                var response = await client.V1.WithNewMerchant("20000").Payments.Create(request, context);

                Assert.NotNull(response);
                Assert.NotNull(response.Payment);
                Assert.NotNull(response.Payment.Id);
            }
            Assert.AreEqual(idempotenceKey, requestHeaders["X-GCS-Idempotence-Key"]);

            Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
            Assert.Null(context.IdempotenceRequestTimestamp);
        }

        private static void RecordRequest(HttpStatusCode statusCode, HttpListenerRequest request, IDictionary<string, string> requestHeaders, HttpListenerResponse response, IDictionary<string, string> responseHeaders)
        {
            foreach (string name in request.Headers)
            {
                requestHeaders.Add(name, request.Headers[name]);
            }
            response.StatusCode = (int)statusCode;
            response.ContentType = "application/json";
        }

        [TestCase]
        public async Task TestIdempotenceFirstFailure()
        {
            var body = IdempotenceRejectedJson;
            var idempotenceKey = Guid.NewGuid().ToString();
            var idempotenceRequestTimestamp = (DateTime.UtcNow - Epoch).TotalMilliseconds;

            var responseHeaders = new Dictionary<string, string>(1)
            {
                { "Location", "http://localhost/v1/20000/payments/000002000020142549460000100001" },
                { "X-GCS-Idempotence-Request-Timestamp", idempotenceRequestTimestamp.ToString() }
            };

            var requestHeaders = new Dictionary<string, string>();

            var context = new CallContext().WithIdempotenceKey(idempotenceKey);
            using (var _ = new MockServer(Port, "/v1/20000/payments", (request, response, arg3) =>
            {
                RecordRequest(HttpStatusCode.PaymentRequired, request, requestHeaders, response, responseHeaders);
                response.StatusCode = 402;
                return body;
            }))
            using (var client = CreateClient())
            {
                try
                {
                    var request = CreateRequest();

                    await client.V1.WithNewMerchant("20000").Payments.Create(request, context);

                    Assert.Fail("Expected DeclinedPaymentException");
                }
                catch (DeclinedPaymentException e)
                {
                    Assert.AreEqual(HttpStatusCode.PaymentRequired, e.StatusCode);
                    Assert.AreEqual(body, e.ResponseBody);
                }
            }
            Assert.AreEqual(idempotenceKey, requestHeaders["X-GCS-Idempotence-Key"]);

            Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
            Assert.Null(context.IdempotenceRequestTimestamp);
        }

        [TestCase]
        public async Task TestIdempotenceSecondFailure()
        {
            var body = IdempotenceRejectedJson;
            var idempotenceKey = Guid.NewGuid().ToString();

            var responseHeaders = new Dictionary<string, string>(1)
            {
                { "Location", "http://localhost/v1/20000/payments/000002000020142549460000100001" }
            };

            var requestHeaders = new Dictionary<string, string>();

            var context = new CallContext().WithIdempotenceKey(idempotenceKey);
            using (var _ = new MockServer(Port, "/v1/20000/payments", (request, response, arg3) =>
            {
                RecordRequest(HttpStatusCode.PaymentRequired, request, requestHeaders, response, responseHeaders);
                response.StatusCode = 402;
                return body;
            }))
            using (var client = CreateClient())
            {
                try
                {
                    var request = CreateRequest();

                    await client.V1.WithNewMerchant("20000").Payments.Create(request, context);

                    Assert.Fail("Expected DeclinedPaymentException");
                }
                catch (DeclinedPaymentException e)
                {
                    Assert.AreEqual(HttpStatusCode.PaymentRequired, e.StatusCode);
                    Assert.AreEqual(body, e.ResponseBody);
                }
            }
            Assert.AreEqual(idempotenceKey, requestHeaders["X-GCS-Idempotence-Key"]);

            Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
            Assert.Null(context.IdempotenceRequestTimestamp);
        }

        [TestCase]
        public async Task TestIdempotenceDuplicateRequest()
        {
            var body = IdempotenceDuplicateFailureJson;
            var idempotenceKey = Guid.NewGuid().ToString();

            var responseHeaders = new Dictionary<string, string>(1)
            {
                { "Location", "http://localhost/v1/20000/payments/000002000020142549460000100001" }
            };

            var requestHeaders = new Dictionary<string, string>();

            var context = new CallContext().WithIdempotenceKey(idempotenceKey);
            using (var _ = new MockServer(Port, "/v1/20000/payments", (request, response, arg3) =>
            {
                RecordRequest((HttpStatusCode)409, request, requestHeaders, response, responseHeaders);
                response.StatusCode = 409;
                return body;
            }))
            using (var client = CreateClient())
            {
                try
                {
                    var request = CreateRequest();

                    await client.V1.WithNewMerchant("20000").Payments.Create(request, context);

                    Assert.Fail("Expected DeclinedPaymentException");
                }
                catch (IdempotenceException e)
                {
                    Assert.AreEqual((HttpStatusCode)409, e.StatusCode);
                    Assert.AreEqual(body, e.ResponseBody);
                }
            }
            Assert.AreEqual(idempotenceKey, requestHeaders["X-GCS-Idempotence-Key"]);

            Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
            Assert.Null(context.IdempotenceRequestTimestamp);
        }
    }
}
