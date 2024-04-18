using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using MockHttpServer;
using System.Net;
using System.Threading.Tasks;
using System.Linq;
using Worldline.Connect.Sdk.Authentication;
using Worldline.Connect.Sdk.Domain;
using Worldline.Connect.Sdk.V1;
using Worldline.Connect.Sdk.V1.Domain;
using Worldline.Connect.Sdk.V1.Merchant.Services;

namespace Worldline.Connect.Sdk.Communication
{
    [TestFixture]
    public class DefaultConnectionLoggerTest
    {
        private const int Port = 5357;

        private const string ConvertAmountJson = @"{
   ""convertedAmount"" : 4547504
}";
        private static readonly string ConvertAmountRequest = Regex.Escape("Outgoing request (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'GET'
  uri:          '/v1/1234/services/convert/amount?source=EUR&target=USD&amount=1000'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + "[^']*" + Regex.Escape("'");
        private static readonly string ConvertAmountResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '200'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
   ""convertedAmount"" : 4547504
}'");

        private const string CreatePaymentFailureRejectedJson = @"{
    ""errorId"": ""833dfd83-52ae-419c-b871-9df1278da93e"",
    ""errors"": [
        {
            ""code"": ""430330"",
            ""message"": ""Not authorised"",
            ""httpStatusCode"": 402
        }
    ],
    ""paymentResult"": {
        ""creationOutput"": {
            ""additionalReference"": ""00000200001000059614"",
            ""externalReference"": ""000002000010000596140000100001""
        },
        ""payment"": {
            ""id"": ""000002000010000596140000100001"",
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
                        ""code"": ""430330"",
                        ""requestId"": ""24162"",
                        ""message"": ""Not authorised"",
                        ""httpStatusCode"": 402
                    }
                ],
                ""isCancellable"": false,
                ""statusCategory"": ""UNSUCCESSFUL"",
                ""statusCode"": 100,
                ""statusCodeChangeDateTime"": ""20160310121151"",
                ""isAuthorized"": false
            }
        }
    }
}";
        private static readonly string CreatePaymentFailureRejectedRequest = Regex.Escape("Outgoing request (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'POST'
  uri:          '/v1/1234/payments'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + "[^']*" + Regex.Escape(@"'
  content-type: 'application/json'
  body:         '{""cardPaymentMethodSpecificInput"":{""card"":{""cvv"":""***"",""cardNumber"":""************3452"",""expiryDate"":""**20""},""paymentProductId"":1},""order"":{""amountOfMoney"":{""amount"":2345,""currencyCode"":""CAD""},""customer"":{""billingAddress"":{""countryCode"":""CA""}}}}'");
        private static readonly string CreatePaymentFailureRejectedResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '402'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""errorId"": ""833dfd83-52ae-419c-b871-9df1278da93e"",
    ""errors"": [
        {
            ""code"": ""430330"",
            ""message"": ""Not authorised"",
            ""httpStatusCode"": 402
        }
    ],
    ""paymentResult"": {
        ""creationOutput"": {
            ""additionalReference"": ""00000200001000059614"",
            ""externalReference"": ""000002000010000596140000100001""
        },
        ""payment"": {
            ""id"": ""000002000010000596140000100001"",
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
                        ""code"": ""430330"",
                        ""requestId"": ""24162"",
                        ""message"": ""Not authorised"",
                        ""httpStatusCode"": 402
                    }
                ],
                ""isCancellable"": false,
                ""statusCategory"": ""UNSUCCESSFUL"",
                ""statusCode"": 100,
                ""statusCodeChangeDateTime"": ""20160310121151"",
                ""isAuthorized"": false
            }
        }
    }
}'");

        private const string CreatePaymentJson = @"{
    ""creationOutput"": {
        ""additionalReference"": ""00000012341000059598"",
        ""externalReference"": ""000000123410000595980000100001""
    },
    ""payment"": {
        ""id"": ""000000123410000595980000100001"",
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
                    ""cardNumber"": ""************3456"",
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
            ""statusCategory"": ""PENDING_MERCHANT"",
            ""statusCode"": 600,
            ""statusCodeChangeDateTime"": ""20160310094054"",
            ""isAuthorized"": true
        }
    }
}";
        private static readonly string CreatePaymentRequest = Regex.Escape("Outgoing request (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'POST'
  uri:          '/v1/1234/payments'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********"", Content-Type=""application/json""") + "[^']*" + Regex.Escape(@"'
  content-type: 'application/json'
  body:         '{""cardPaymentMethodSpecificInput"":{""card"":{""cvv"":""***"",""cardNumber"":""************3456"",""expiryDate"":""**20""},""paymentProductId"":1},""order"":{""amountOfMoney"":{""amount"":2345,""currencyCode"":""CAD""},""customer"":{""billingAddress"":{""countryCode"":""CA""}}}}'");
        private static readonly string CreatePaymentResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '201'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")(?=('|.*, )Location=""http://localhost/v1/1234/payments/000000123410000595980000100001"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""creationOutput"": {
        ""additionalReference"": ""00000012341000059598"",
        ""externalReference"": ""000000123410000595980000100001""
    },
    ""payment"": {
        ""id"": ""000000123410000595980000100001"",
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
                    ""cardNumber"": ""************3456"",
                    ""expiryDate"": ""**20""
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
            ""statusCategory"": ""PENDING_MERCHANT"",
            ""statusCode"": 600,
            ""statusCodeChangeDateTime"": ""20160310094054"",
            ""isAuthorized"": true
        }
    }
}'");

        private const string CreatePaymentUnicodeJson = @"{
    ""creationOutput"": {
        ""additionalReference"": ""00000012341000059598"",
        ""externalReference"": ""000000123410000595980000100001""
    },
    ""payment"": {
        ""id"": ""000000123410000595980000100001"",
        ""paymentOutput"": {
            ""amountOfMoney"": {
                ""amount"": 2345,
                ""currencyCode"": ""CAD""
            },
            ""references"": {
                ""paymentReference"": ""0""
            },
            ""paymentMethod"": ""redirect"",
            ""redirectPaymentMethodSpecificOutput"":{
               ""paymentProductId"":840,
               ""paymentProduct840SpecificOutput"":{
                  ""customerAccount"":{
                     ""firstName"":""Theresa"",
                     ""surname"":""Schröder""
                  },
                  ""customerAddress"":{
                     ""city"":""sittensen"",
                     ""countryCode"":""DE"",
                     ""street"":""Westerberg 25"",
                     ""zip"":""27419""
                  }
               }
            }
        },
        ""status"": ""PENDING_APPROVAL"",
        ""statusOutput"": {
            ""isCancellable"": true,
            ""statusCategory"": ""PENDING_MERCHANT"",
            ""statusCode"": 600,
            ""statusCodeChangeDateTime"": ""20160310094054"",
            ""isAuthorized"": true
        }
    }
}";
        private static readonly string CreatePaymentUnicodeRequest = Regex.Escape("Outgoing request (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'POST'
  uri:          '/v1/1234/payments'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********"", Content-Type=""application/json""") + "[^']*" + Regex.Escape(@"'
  content-type: 'application/json'
  body:         '{""cardPaymentMethodSpecificInput"":{""card"":{""cvv"":""***"",""cardNumber"":""************3456"",""expiryDate"":""**20""},""paymentProductId"":1},""order"":{""amountOfMoney"":{""amount"":2345,""currencyCode"":""CAD""},""customer"":{""billingAddress"":{""countryCode"":""CA""}}}}'");
        private static readonly string CreatePaymentUnicodeResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '201'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")(?=('|.*, )Location=""http://localhost/v1/1234/payments/000000123410000595980000100001"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""creationOutput"": {
        ""additionalReference"": ""00000012341000059598"",
        ""externalReference"": ""000000123410000595980000100001""
    },
    ""payment"": {
        ""id"": ""000000123410000595980000100001"",
        ""paymentOutput"": {
            ""amountOfMoney"": {
                ""amount"": 2345,
                ""currencyCode"": ""CAD""
            },
            ""references"": {
                ""paymentReference"": ""0""
            },
            ""paymentMethod"": ""redirect"",
            ""redirectPaymentMethodSpecificOutput"":{
               ""paymentProductId"":840,
               ""paymentProduct840SpecificOutput"":{
                  ""customerAccount"":{
                     ""firstName"":""Theresa"",
                     ""surname"":""Schröder""
                  },
                  ""customerAddress"":{
                     ""city"":""sittensen"",
                     ""countryCode"":""DE"",
                     ""street"":""Westerberg 25"",
                     ""zip"":""27419""
                  }
               }
            }
        },
        ""status"": ""PENDING_APPROVAL"",
        ""statusOutput"": {
            ""isCancellable"": true,
            ""statusCategory"": ""PENDING_MERCHANT"",
            ""statusCode"": 600,
            ""statusCodeChangeDateTime"": ""20160310094054"",
            ""isAuthorized"": true
        }
    }
}'");

        private const string CreatePaymentFailureInvalidCardNumberJson = @"{
    ""errorId"": ""0953f236-9e54-4f23-9556-d66bc757dda8"",
    ""errors"": [
        {
            ""code"": ""21000020"",
            ""requestId"": ""24146"",
            ""message"": ""VALUE **************** OF FIELD CREDITCARDNUMBER DID NOT PASS THE LUHNCHECK"",
            ""httpStatusCode"": 400
        }
    ]
}";
        private static readonly string CreatePaymentFailureInvalidCardNumberJsonRequest = Regex.Escape("Outgoing request (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'POST'
  uri:          '/v1/1234/payments'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + "[^']*" + Regex.Escape(@"'
  content-type: 'application/json'
  body:         '{""cardPaymentMethodSpecificInput"":{""card"":{""cvv"":""***"",""cardNumber"":""************3456"",""expiryDate"":""**20""},""paymentProductId"":1},""order"":{""amountOfMoney"":{""amount"":2345,""currencyCode"":""CAD""},""customer"":{""billingAddress"":{""countryCode"":""CA""}}}}'");
        private static readonly string CreatePaymentFailureInvalidCardNumberJsonResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '400'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""errorId"": ""0953f236-9e54-4f23-9556-d66bc757dda8"",
    ""errors"": [
        {
            ""code"": ""21000020"",
            ""requestId"": ""24146"",
            ""message"": ""VALUE **************** OF FIELD CREDITCARDNUMBER DID NOT PASS THE LUHNCHECK"",
            ""httpStatusCode"": 400
        }
    ]
}'");

        private static readonly string DeleteTokenRequest = Regex.Escape("Outgoing request (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'DELETE'
  uri:          '/v1/1234/tokens/5678'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + "[^']*" + Regex.Escape("'");
        private static readonly string DeleteTokenResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '204'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: ''
  body:         ''");

        private const string TestConnectionJson = @"{
    ""result"": ""OK""
}";
        private static readonly string TestConnectionRequest = Regex.Escape("Outgoing request (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("')") + Regex.Escape(@":
  method:       'GET'
  uri:          '/v1/1234/services/testconnection'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + "[^']*" + Regex.Escape("'");
        private static readonly string TestConnectionResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '200'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""result"": ""OK""
}'");

        private static readonly string BinaryRequestRequest = Regex.Escape("Outgoing request (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'POST'
  uri:          '/binaryRequest'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + "[^']*" + Regex.Escape(@"'
  content-type: 'multipart/form-data; boundary=") + ".*" + Regex.Escape(@"'
  body:         '<binary content>'");
        private static readonly string BinaryRequestResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '204'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: ''
  body:         ''");

        private static readonly string BinaryResponseRequest = Regex.Escape("Outgoing request (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'GET'
  uri:          '/binaryContent'
  headers:      '") + "[^']*" + Regex.Escape("'");
        private static readonly string BinaryResponseResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '200'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/octet-stream'
  body:         '<binary content>'");

        private const string UnknownServerErrorJson = @"{
    ""errorId"": ""fbff1179-7ba4-4894-9021-d8a0011d23a7"",
    ""errors"": [
        {
            ""code"": ""9999"",
            ""message"": ""UNKNOWN_SERVER_ERROR"",
            ""httpStatusCode"": 500
        }
    ]
}";
        private static readonly string UnknownServerErrorResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '500'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""errorId"": ""fbff1179-7ba4-4894-9021-d8a0011d23a7"",
    ""errors"": [
        {
            ""code"": ""9999"",
            ""message"": ""UNKNOWN_SERVER_ERROR"",
            ""httpStatusCode"": 500
        }
    ]
}'");

        private const string NotFoundHtml = "Not Found";
        private static readonly string NotFoundResponse = Regex.Escape("Incoming response (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("' + '") + "[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '404'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'text/html'
  body:         'Not Found'");

        private static readonly string GenericError = Regex.Escape("Error occurred for outgoing request (requestId='") + "([-a-zA-Z0-9]+)" + Regex.Escape("')");

        [TestCase]
        public async Task TestLoggingTestConnection()
        {
            // GET with no query params
            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);

                       return TestConnectionJson;
                   }))
            using (var client = CreateClient())
            {
                client.EnableLogging(logger);

                var response = await client.V1.WithNewMerchant("1234").Services.Testconnection();

                Assert.That(response, Is.Not.Null);
                Assert.That("OK", Is.EqualTo(response.Result));

            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, TestConnectionRequest, TestConnectionResponse);
        }

        [TestCase]
        public async Task TestLoggingConvertAmount()
        {
            // GET with query params

            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/v1/1234/services/convert/amount", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);

                       return ConvertAmountJson;
                   }))
            using (var client = CreateClient())
            {
                client.EnableLogging(logger);
                var query = new ConvertAmountParams
                {
                    Amount = 1000L,
                    Source = "EUR",
                    Target = "USD"
                };
                var response = await client.V1.WithNewMerchant("1234").Services.ConvertAmount(query);

                Assert.NotNull(response);
                Assert.NotNull(response.ConvertedAmount);
            }

            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.NotNull(responseEntry.Message);
            Assert.Null(responseEntry.Thrown);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, ConvertAmountRequest, ConvertAmountResponse);
        }

        [TestCase]
        public async Task TestDeleteToken()
        {
            // POST with no request body and a void response

            var logger = new TestLogger();

            using (var _ = new MockServer(5357, "/v1/1234/tokens/5678", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)204, new Dictionary<string, string>(), response, contentType: null);
                       return null;
                   }))
            using (var client = CreateClient())
            {
                client.EnableLogging(logger);
                await client.V1.WithNewMerchant("1234").Tokens.Delete("5678", null);

            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.NotNull(responseEntry.Message);
            Assert.Null(responseEntry.Thrown);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, DeleteTokenRequest, DeleteTokenResponse);
        }

        [TestCase]
        public async Task TestLoggingCreatePayment()
        {
            // POST with a success (201) response
            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/v1/1234/payments", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)201, new Dictionary<string, string>(), response, "http://localhost/v1/1234/payments/000000123410000595980000100001");

                       return CreatePaymentJson;
                   }))
            using (var client = CreateClient())
            {
                client.EnableLogging(logger);

                var amountOfMoney = new AmountOfMoney
                {
                    CurrencyCode = "CAD",
                    Amount = 2345L
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
                    CardNumber = "1234567890123456",
                    ExpiryDate = "1220"
                };

                var paymentMethodSpecificInput = new CardPaymentMethodSpecificInput
                {
                    PaymentProductId = 1,
                    Card = card
                };

                var request = new CreatePaymentRequest
                {
                    Order = order,
                    CardPaymentMethodSpecificInput = paymentMethodSpecificInput
                };

                var response = await client.V1.WithNewMerchant("1234").Payments.Create(request);

                Assert.NotNull(response);
                Assert.NotNull(response.Payment);
                Assert.NotNull(response.Payment.Id);
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, CreatePaymentRequest, CreatePaymentResponse);
        }

        [TestCase]
        public async Task TestLoggingCreatePaymentUnicode()
        {
            // POST with a success (201) response
            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/v1/1234/payments", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)201, new Dictionary<string, string>(), response, "http://localhost/v1/1234/payments/000000123410000595980000100001");

                       return CreatePaymentUnicodeJson;
                   }))
            using (var client = CreateClient())
            {
                client.EnableLogging(logger);

                var amountOfMoney = new AmountOfMoney
                {
                    CurrencyCode = "CAD",
                    Amount = 2345L
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
                    CardNumber = "1234567890123456",
                    ExpiryDate = "1220"
                };

                var paymentMethodSpecificInput = new CardPaymentMethodSpecificInput
                {
                    PaymentProductId = 1,
                    Card = card
                };

                var request = new CreatePaymentRequest
                {
                    Order = order,
                    CardPaymentMethodSpecificInput = paymentMethodSpecificInput
                };

                var response = await client.V1.WithNewMerchant("1234").Payments.Create(request);

                Assert.NotNull(response);
                Assert.NotNull(response.Payment);
                Assert.NotNull(response.Payment.Id);
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, CreatePaymentUnicodeRequest, CreatePaymentUnicodeResponse);
        }

        [TestCase]
        public void TestCreatePaymentInvalidCardNumber()
        {
            // an exception is thrown after logging the response

            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/v1/1234/payments", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)400, new Dictionary<string, string>(), response);

                       return CreatePaymentFailureInvalidCardNumberJson;
                   }))
            using (var client = CreateClient())
            {
                client.EnableLogging(logger);

                var amountOfMoney = new AmountOfMoney
                {
                    CurrencyCode = "CAD",
                    Amount = 2345L
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
                    CardNumber = "1234567890123456",
                    ExpiryDate = "1220"
                };

                var paymentMethodSpecificInput = new CardPaymentMethodSpecificInput
                {
                    PaymentProductId = 1,
                    Card = card
                };

                var request = new CreatePaymentRequest
                {
                    Order = order,
                    CardPaymentMethodSpecificInput = paymentMethodSpecificInput
                };

                Assert.CatchAsync(typeof(ValidationException), async () => await client.V1.WithNewMerchant("1234").Payments.Create(request));
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, CreatePaymentFailureInvalidCardNumberJsonRequest, CreatePaymentFailureInvalidCardNumberJsonResponse);
        }

        [TestCase]
        public void TestCreatePaymentRejected()
        {
            // an exception is thrown after logging the response

            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/v1/1234/payments", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)402, new Dictionary<string, string>(), response);

                       return CreatePaymentFailureRejectedJson;
                   }))
            using (var client = CreateClient())
            {
                client.EnableLogging(logger);

                var amountOfMoney = new AmountOfMoney
                {
                    CurrencyCode = "CAD",
                    Amount = 2345L
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
                    CardNumber = "1234567890123452",
                    ExpiryDate = "1220"
                };

                var paymentMethodSpecificInput = new CardPaymentMethodSpecificInput
                {
                    PaymentProductId = 1,
                    Card = card
                };

                var request = new CreatePaymentRequest
                {
                    Order = order,
                    CardPaymentMethodSpecificInput = paymentMethodSpecificInput
                };

                Assert.CatchAsync(typeof(DeclinedPaymentException), async () => await client.V1.WithNewMerchant("1234").Payments.Create(request));
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, CreatePaymentFailureRejectedRequest, CreatePaymentFailureRejectedResponse);
        }

        [TestCase]
        public async Task TestBinaryRequestWithKnownLength()
        {
            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/binaryRequest", (request, response, arg3) =>
                    {
                        AssignResponse((HttpStatusCode)204, new Dictionary<string, string>(), response, contentType: null);
                        return null;
                    }))
            using (var communicator = CreateCommunicator())
            {
                communicator.EnableLogging(logger);

                var data = new byte[1024];
                new Random().NextBytes(data);

                var file = new UploadableFile("dummyFile", new MemoryStream(data), "application/octetstream", data.Length);
                var multipart = new MultipartFormDataObject();
                multipart.AddFile("file", file);

                await communicator.Post<object>("/binaryRequest", new List<IRequestHeader>(), null, multipart, null);
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, BinaryRequestRequest, BinaryRequestResponse);
        }

        [TestCase]
        public async Task TestBinaryRequestWithUnknownLength()
        {
            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/binaryRequest", (request, response, arg3) =>
                    {
                        AssignResponse((HttpStatusCode)204, new Dictionary<string, string>(), response, contentType: null);
                        return null;
                    }))
            using (var communicator = CreateCommunicator())
            {
                communicator.EnableLogging(logger);

                var data = new byte[1024];
                new Random().NextBytes(data);

                var file = new UploadableFile("dummyFile", new MemoryStream(data), "application/octetstream");
                var multipart = new MultipartFormDataObject();
                multipart.AddFile("file", file);

                await communicator.Post<object>("/binaryRequest", new List<IRequestHeader>(), null, multipart, null);
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, BinaryRequestRequest, BinaryRequestResponse);
        }

        [TestCase]
        public async Task TestBinaryResponse()
        {
            var logger = new TestLogger();

            var data = new byte[10];
            new Random().NextBytes(data);

            using (var _ = new MockServer(Port, "/binaryContent", (request, response, arg3) =>
                    {
                        AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response, null, "application/octet-stream");
                        new MemoryStream(data).CopyTo(response.OutputStream);
                    }))
            using (var connection = CreateConnection())
            {
                connection.EnableLogging(logger);

                var uriBuilder = new UriBuilder("http", "localhost")
                {
                    Port = 5357,
                    Path = "/binaryContent"
                };
                await connection.Get<object>(uriBuilder.Uri, new List<IRequestHeader>(), (statusCode, stream, headers) => {
                    var memStream = new MemoryStream();
                    stream.CopyTo(memStream);

                    Assert.That(statusCode, Is.EqualTo(HttpStatusCode.OK));
                    Assert.That(memStream.ToArray(), Is.EqualTo(data));

                    return null;
                });
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, BinaryResponseRequest, BinaryResponseResponse);
        }

        [TestCase]
        public async Task TestVoidContent()
        {
            // reuse delete token
            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/v1/1234/tokens/5678", (request, response, arg3) =>
                    {
                        AssignResponse((HttpStatusCode)204, new Dictionary<string, string>(), response, contentType: null);
                        return null;
                    }))
            using (var communicator = CreateCommunicator())
            {
                communicator.EnableLogging(logger);

                await communicator.Delete("/v1/1234/tokens/5678", new List<IRequestHeader>(), null, (stream, headers) => {
                    Assert.That(stream.ReadByte(), Is.EqualTo(-1));
                }, null);
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, DeleteTokenRequest, DeleteTokenResponse);
        }

        [TestCase]
        public void TestLoggingUnknownServerError()
        {
            // an exception is thrown after logging the response

            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)500, new Dictionary<string, string>(), response);

                       return UnknownServerErrorJson;
                   }))
            using (var client = CreateClient())
            {
                client.EnableLogging(logger);

                Assert.CatchAsync(typeof(PlatformException), async () => await client.V1.WithNewMerchant("1234").Services.Testconnection());
            }

            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.NotNull(responseEntry.Message);
            Assert.Null(responseEntry.Thrown);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, TestConnectionRequest, UnknownServerErrorResponse);
        }

        [TestCase]
        public void TestNonJson()
        {
            // an exception is thrown after logging the response

            var logger = new TestLogger();

            using (var _ = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)404, new Dictionary<string, string>(), response, contentType: "text/html");

                       return NotFoundHtml;
                   }))
            using (var client = CreateClient())
            {
                client.EnableLogging(logger);

                Assert.CatchAsync(typeof(NotFoundException), async () => await client.V1.WithNewMerchant("1234").Services.Testconnection());
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            var responseEntry = logger.Entries.ElementAt(1);

            Assert.NotNull(responseEntry.Message);
            Assert.Null(responseEntry.Thrown);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, TestConnectionRequest, NotFoundResponse);
        }

        [TestCase]
        public void TestReadTimeout()
        {
            // an exception is thrown before logging the response

            var logger = new TestLogger();
            using (var client = CreateClient(1, 10))
            using (var _ = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);
                       System.Threading.Thread.Sleep(500);

                       return TestConnectionJson;
                   }))
            {
                client.EnableLogging(logger);
                Assert.That(async () => await client.V1.WithNewMerchant("1234").Services.Testconnection(),
                            Throws.Exception.TypeOf(typeof(CommunicationException))
                            .And.InnerException.TypeOf(typeof(TaskCanceledException)));

            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            var requestEntry = logger.Entries.First();
            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            var errorEntry = logger.Entries.ElementAt(1);

            Assert.NotNull(errorEntry.Message);
            Assert.NotNull(errorEntry.Thrown);

            AssertRequestAndError(requestEntry.Message, errorEntry.Message, TestConnectionRequest);
        }

        [TestCase]
        public async Task TestLogRequestOnly()
        {
            // logging is disabled after the request is logged but before the response is logged

            var logger = new TestLogger();
            using (var client = CreateClient())
            using (var _ = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);
                       client.DisableLogging();

                       return TestConnectionJson;
                   }))
            {
                client.EnableLogging(logger);

                var response = await client.V1.WithNewMerchant("1234").Services.Testconnection();

                Assert.NotNull(response);
                Assert.AreEqual("OK", response.Result);
            }

            Assert.That(logger.Entries, Has.Count.EqualTo(1));
            var requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            AssertRequest(requestEntry.Message, TestConnectionRequest);
        }

        [TestCase]
        public async Task TestLogResponseOnly()
        {
            // logging is disabled after the request is logged but before the response is logged

            var logger = new TestLogger();
            using (var client = CreateClient())
            using (var _ = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);
                       client.EnableLogging(logger);

                       return TestConnectionJson;
                   }))
            {
                var response = await client.V1.WithNewMerchant("1234").Services.Testconnection();

                Assert.NotNull(response);
                Assert.AreEqual("OK", response.Result);
            }

            Assert.That(logger.Entries, Has.Count.EqualTo(1));

            var requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            AssertResponse(requestEntry.Message, TestConnectionResponse);
        }

        [TestCase]
        public void TestLogErrorOnly()
        {
            // logging is enabled after the request is logged but before the error is logged

            var logger = new TestLogger();
            using (var client = CreateClient(100, 100))
            using (var _ = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);
                       client.EnableLogging(logger);
                       System.Threading.Thread.Sleep(500);

                       return TestConnectionJson;
                   }))
            {
                Assert.That(async () => await client.V1.WithNewMerchant("1234").Services.Testconnection(),
                            Throws.Exception.TypeOf(typeof(CommunicationException))
                            .And.InnerException.TypeOf(typeof(TaskCanceledException)));
            }

            Assert.That(logger.Entries, Has.Count.EqualTo(1));

            var errorEntry = logger.Entries.First();

            Assert.NotNull(errorEntry.Message);
            Assert.NotNull(errorEntry.Thrown);

            AssertError(errorEntry.Message);
        }

        private static void AssertRequestAndError(string requestMessage, string errorMessage, string requestPattern)
        {
            var requestId = AssertRequest(requestMessage, requestPattern);
            AssertError(errorMessage, requestId);
        }

        private static IConnection CreateConnection(int connectTimeout = 50000, int socketTimeout = 50000)
        {
            // Connect timeout not implemented
            return new DefaultConnection(TimeSpan.FromMilliseconds(socketTimeout));
        }

        private static Communicator CreateCommunicator(int connectTimeout = 50000, int socketTimeout = 50000)
        {
            var connection = CreateConnection(connectTimeout, socketTimeout);
            var authenticator = new V1HMACAuthenticator("apiKey", "secret");
            var metadataProvider = new MetadataProvider("Worldline");
            var uriBuilder = new UriBuilder("http", "localhost")
            {
                Port = 5357
            };
            return Factory.CreateCommunicator(uriBuilder.Uri, connection, authenticator, metadataProvider);
        }

        private static Client CreateClient(int connectTimeout = 50000, int socketTimeout = 50000)
        {
            var communicator = CreateCommunicator(connectTimeout, socketTimeout);
            var client = Factory.CreateClient(communicator);
            return client;
        }

        private static void AssertRequestAndResponse(string requestMessage, string responseMessage, string requestPattern, string responsePattern)
        {
            var requestId = AssertRequest(requestMessage, requestPattern);
            AssertResponse(responseMessage, responsePattern, requestId);
        }

        private static string AssertRequest(string requestMessage, string requestPattern)
        {
            Assert.That(requestMessage, Does.Match(requestPattern));
            var requestMatches = Regex.Match(requestMessage, requestPattern);
            var requestId = requestMatches.Groups[1].Value;
            return requestId;
        }

        private static void AssertResponse(string responseMessage, string responsePattern, string requestId = null)
        {
            Assert.That(responseMessage, Does.Match(responsePattern));
            var responseMatch = Regex.Match(responseMessage, responsePattern);

            var responseRequestId = responseMatch.Groups[1].Value;
            if (requestId != null)
            {
                Assert.AreEqual(requestId, responseRequestId, "response requestId '" + responseRequestId + "' does not match request requestId '" + requestId + "'");
            }
        }

        private static void AssertError(string message, string requestId = null)
        {
            Assert.That(message, Does.Match(GenericError));

            var responseMatch = Regex.Match(message, GenericError);

            var errorRequestId = responseMatch.Groups[1].Value;

            if (requestId != null)
            {
                Assert.AreEqual(errorRequestId, requestId, "error requestId '" + errorRequestId + "' does not match earlier requestId '" + requestId + "'");
            }
        }

        private static void AssignResponse(HttpStatusCode statusCode, IDictionary additionalHeaders, HttpListenerResponse response, string location = null, string contentType = "application/json")
        {
            response.StatusCode = (int)statusCode;
            if (contentType != null)
            {
                response.Headers.Add("Content-Type", contentType);
            }

            response.Headers.Add("Dummy", null);

            if (location != null)
            {
                response.Headers.Add("Location", location);
            }
            foreach (KeyValuePair<string, string> entry in additionalHeaders)
            {
                response.Headers.Add(entry.Key, entry.Value);
            }
        }

        private class TestLogger : Logging.ICommunicatorLogger
        {
            public IList<TestLoggerEntry> Entries { get; } = new List<TestLoggerEntry>();

            public void Log(string message)
            {
                Log(message, null);
            }

            public void Log(string message, Exception thrown)
            {
                Entries.Add(new TestLoggerEntry(message, thrown));
            }
        }

        private class TestLoggerEntry
        {
            public string Message { get; }
            public Exception Thrown { get; }
            public TestLoggerEntry(string message, Exception thrown)
            {
                Message = message;
                Thrown = thrown;
            }
        }
    }
}
