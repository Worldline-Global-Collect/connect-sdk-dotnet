using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using Worldline.Connect.Sdk.Authentication;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Payments
{
    [TestFixture]
    public class PaymentsClientTest
    {
        private const string PendingApprovalJson = @"{
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
        private const string DuplicateRequestJson = @"{
   ""errorId"" : ""75b0f13a-04a5-41b3-83b8-b295ddb23439-000013c6"",
   ""errors"" : [ {
      ""code"" : ""1409"",
      ""message"" : ""DUPLICATE REQUEST IN PROGRESS"",
      ""httpStatusCode"" : 409
   } ]
}";
        private const string InvalidAuthorizationJson = @"{
    ""errorId"": ""fbd8d914-c889-45d3-a396-9e0d9ff9db88-0000006f"",
    ""errors"": [
        {
            ""code"": ""9002"",
            ""message"": ""MISSING_OR_INVALID_AUTHORIZATION""
        }
    ]
}";
        private const string InvalidRequestJson = @"{
    ""errorId"": ""2c164323-20d3-4e9e-8578-dc562cd7506c-00000058"",
    ""errors"": [
        {
            ""code"": ""21000120"",
            ""requestId"": ""2001803"",
            ""propertyName"": ""cardPaymentMethodSpecificInput.card.expiryDate"",
            ""message"": ""paymentMethodSpecificInput.card.expiryDate (1210) IS IN THE PAST OR NOT IN CORRECT MMYY FORMAT""
        }
    ]
}";
        private const string RejectedJson = @"{
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
        private const string MethodNotAllowedHtml = "Method Not Allowed";
        private const string NotFoundHtml = "Not Found";

        private  static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        /// <summary>
        /// Tests that a non-failure response will not throw an exception.
        /// </summary>
        [TestCase]
        public async Task TestCreateSuccess()
        {
            var connectionMock = new Mock<IConnection>();
            // new Response((HttpStatusCode)201, pendingApprovalJson, null
            var jsonStream = GenerateStreamFromString(PendingApprovalJson);
            connectionMock.Setup(arg
                    => arg.Post(It.IsAny<Uri>(), It.IsAny<IEnumerable<IRequestHeader>>(), It.IsAny<string>(), It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)201, jsonStream, new List<IResponseHeader>())));

            var apiEndpoint = new Uri("http://localhost");
            var authenticator = new V1HMACAuthenticator("test", "test");
            var metadataProvider = new MetadataProvider("Worldline");
            var communicator = Factory.CreateCommunicator(apiEndpoint, connectionMock.Object, authenticator, metadataProvider);

            var client = Factory.CreateClient(communicator);

            var body = CreateRequest();

            var response = await client.V1.WithNewMerchant("merchantId").Payments.Create(body);
            Assert.AreEqual("000002000020142549460000100001", response.Payment.Id);
            Assert.AreEqual("PENDING_APPROVAL", response.Payment.Status);
        }

        /// <summary>
        /// Tests that a failure response with a payment result will throw a <see cref="DeclinedPaymentException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateRejected()
        {
            var connectionMock = new Mock<IConnection>();

            connectionMock.Setup(arg
                    => arg.Post(It.IsAny<Uri>(), It.IsAny<IEnumerable<IRequestHeader>>(), It.IsAny<string>(), It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                        .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)400, GenerateStreamFromString(RejectedJson), new List<IResponseHeader>())));

            var apiEndpoint = new Uri("http://localhost");
            var authenticator = new V1HMACAuthenticator("test", "test");
            var metadataProvider = new MetadataProvider("Worldline");
            var communicator = Factory.CreateCommunicator(apiEndpoint, connectionMock.Object, authenticator, metadataProvider);

            var client = Factory.CreateClient(communicator);

            var body = CreateRequest();

            try
            {
                await client.V1.WithNewMerchant("merchantId").Payments.Create(body);
                Assert.Fail("DeclinedPaymentException expected");
            }
            catch (DeclinedPaymentException e)
            {
                Assert.That(e.ToString(), Does.Contain("payment '000002000020142544360000100001'"));
                Assert.That(e.ToString(), Does.Contain("status 'REJECTED'"));
                Assert.That(e.ToString(), Does.Contain(RejectedJson));
                Assert.That(e.CreatePaymentResult, Is.Not.Null);
                Assert.That(e.CreatePaymentResult.Payment.Id, Is.EqualTo("000002000020142544360000100001"));
                Assert.That(e.CreatePaymentResult.Payment.Status, Is.EqualTo("REJECTED"));
            }
        }

        /// <summary>
        /// Tests that a 400 failure response without a payment result will throw a <see cref="ValidationException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateInvalidRequest()
        {
            var connectionMock = new Mock<IConnection>();

            connectionMock.Setup(arg
                    => arg.Post(It.IsAny<Uri>(), It.IsAny<IEnumerable<IRequestHeader>>(), It.IsAny<string>(), It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)400, GenerateStreamFromString(InvalidRequestJson), new List<IResponseHeader>())));


            var apiEndpoint = new Uri("http://localhost");
            var authenticator = new V1HMACAuthenticator("test", "test");
            var metadataProvider = new MetadataProvider("Worldline");
            var communicator = Factory.CreateCommunicator(apiEndpoint, connectionMock.Object, authenticator, metadataProvider);

            var client = Factory.CreateClient(communicator);

            var body = CreateRequest();

            try
            {
                await client.V1.WithNewMerchant("merchantId").Payments.Create(body);
                Assert.Fail("ValidationException expected");
            }
            catch (ValidationException e)
            {
                Assert.That(e.ToString(), Does.Contain(InvalidRequestJson));
            }
        }

        /// <summary>
        /// Tests that a 401 failure response without a payment result will throw a <see cref="ApiException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateInvalidAuthorization()
        {
            var connectionMock = new Mock<IConnection>();

            connectionMock.Setup(arg
                    => arg.Post(It.IsAny<Uri>(), It.IsAny<IEnumerable<IRequestHeader>>(), It.IsAny<string>(), It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)401, GenerateStreamFromString(InvalidAuthorizationJson), new List<IResponseHeader>())));

            var apiEndpoint = new Uri("http://localhost");
            var authenticator = new V1HMACAuthenticator("test", "test");
            var metadataProvider = new MetadataProvider("Worldline");
            var communicator = Factory.CreateCommunicator(apiEndpoint, connectionMock.Object, authenticator, metadataProvider);

            var client = Factory.CreateClient(communicator);

            var body = CreateRequest();

            try
            {
                await client.V1.WithNewMerchant("merchantId").Payments.Create(body);
                Assert.Fail("Api exception expected");
            }
            catch (ApiException e)
            {
                Assert.That(e.ToString(), Does.Contain(InvalidAuthorizationJson));
            }
        }

        /// <summary>
        /// Tests that a 409 failure response with a duplicate request code but without an idempotence key will throw a
        /// <see cref="ReferenceException"/> .
        /// </summary>
        [TestCase]
        public async Task TestCreateReferenceError()
        {
            var connectionMock = new Mock<IConnection>();

            connectionMock.Setup(arg
                    => arg.Post(It.IsAny<Uri>(), It.IsAny<IEnumerable<IRequestHeader>>(), It.IsAny<string>(), It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)409, GenerateStreamFromString(DuplicateRequestJson), new List<IResponseHeader>())));

            var apiEndpoint = new Uri("http://localhost");
            var authenticator = new V1HMACAuthenticator("test", "test");
            var metadataProvider = new MetadataProvider("Worldline");
            var communicator = Factory.CreateCommunicator(apiEndpoint, connectionMock.Object, authenticator, metadataProvider);

            var client = Factory.CreateClient(communicator);

            var body = CreateRequest();

            try
            {
                await client.V1.WithNewMerchant("merchantId").Payments.Create(body);
                Assert.Fail("Reference exception expected");
            }
            catch (ReferenceException e)
            {
                Assert.That(e.ToString(), Does.Contain(DuplicateRequestJson));
            }
        }

        /// <summary>
        /// Tests that a 409 failure response with a duplicate request code and an idempotence key will throw an <see cref="IdempotenceException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateIdempotenceError()
        {
            const string responseBody = DuplicateRequestJson;
            const string idempotenceKey = "key";
            var connectionMock = new Mock<IConnection>();
            connectionMock.Setup(arg
                    => arg.Post(It.IsAny<Uri>(), It.IsAny<IEnumerable<IRequestHeader>>(), It.IsAny<string>(), It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)409, GenerateStreamFromString(responseBody), null)));

            var apiEndpoint = new Uri("http://localhost");
            var authenticator = new V1HMACAuthenticator("test", "test");
            var metadataProvider = new MetadataProvider("Worldline");
            var communicator = Factory.CreateCommunicator(apiEndpoint, connectionMock.Object, authenticator, metadataProvider);

            var client = Factory.CreateClient(communicator);

            var context = new CallContext().WithIdempotenceKey(idempotenceKey);

            var body = CreateRequest();

            try
            {
                await client.V1.WithNewMerchant("merchantId").Payments.Create(body, context);
                Assert.Fail("Idempotence exception expected");
            }
            catch (IdempotenceException e)
            {
                Assert.That(e.ToString(), Does.Contain(responseBody));
                Assert.That(e.IdempotenceKey, Is.EqualTo(context.IdempotenceKey));
            }
        }

        /// <summary>
        /// Tests that a 404 response with a non-JSON response will throw a <see cref="NotFoundException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateNotFound()
        {
            const string responseBody = NotFoundHtml;
            var connectionMock = new Mock<IConnection>();
            connectionMock.Setup(arg
                    => arg.Post(It.IsAny<Uri>(), It.IsAny<IEnumerable<IRequestHeader>>(), It.IsAny<string>(), It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)404, GenerateStreamFromString(responseBody), new List<IResponseHeader> { new ResponseHeader("content-type", "text/html") })));

            var apiEndpoint = new Uri("http://localhost");
            var authenticator = new V1HMACAuthenticator("test", "test");
            var metadataProvider = new MetadataProvider("Worldline");
            var communicator = Factory.CreateCommunicator(apiEndpoint, connectionMock.Object, authenticator, metadataProvider);

            var client = Factory.CreateClient(communicator);

            var body = CreateRequest();

            try
            {
                await client.V1.WithNewMerchant("merchantId").Payments.Create(body);
                Assert.Fail("NotFoundException exception expected");
            }
            catch (NotFoundException e)
            {
                Assert.That(e.InnerException, Is.Not.Null);
                Assert.That(e.InnerException, Is.TypeOf(typeof(ResponseException)));
                Assert.That(e.InnerException.ToString(), Does.Contain(responseBody));
            }
        }

        /// <summary>
        /// Tests that a 405 response with a non-JSON response will throw a <see cref="CommunicationException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateMethodNotAllowed()
        {
            const string responseBody = MethodNotAllowedHtml;
            var connectionMock = new Mock<IConnection>();
            connectionMock.Setup(arg
                    => arg.Post(It.IsAny<Uri>(), It.IsAny<IEnumerable<IRequestHeader>>(), It.IsAny<string>(), It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)405, GenerateStreamFromString(responseBody), new List<IResponseHeader> { new ResponseHeader("content-type", "text/html") })));

            var apiEndpoint = new Uri("http://localhost");
            var authenticator = new V1HMACAuthenticator("test", "test");
            var metadataProvider = new MetadataProvider("Worldline");
            var communicator = Factory.CreateCommunicator(apiEndpoint, connectionMock.Object, authenticator, metadataProvider);

            var client = Factory.CreateClient(communicator);

            var body = CreateRequest();

            try
            {
                await client.V1.WithNewMerchant("merchantId").Payments.Create(body);
                Assert.Fail("ResponseException exception expected");
            }
            catch (CommunicationException e)
            {
                Assert.That(e.InnerException, Is.Not.Null);
                Assert.That(e.InnerException, Is.TypeOf(typeof(ResponseException)));
                Assert.That(e.InnerException.ToString(), Does.Contain(responseBody));
            }
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
                Order = order,
                CardPaymentMethodSpecificInput = cardPaymentMethodSpecificInput
            };

            return body;
        }
    }
}
