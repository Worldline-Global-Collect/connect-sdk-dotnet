using NUnit.Framework;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;

namespace Worldline.Connect.Sdk.Authentication
{
    [TestFixture]
    public class V1HMACAuthenticatorTest
    {
        [TestCase]
        public void TestToCanonicalizeHeaderValue()
        {
            Assert.AreEqual("foo bar", V1HMACAuthenticator.ToCanonicalizeHeaderValue("foo\nbar  "));
            Assert.AreEqual("foo bar", V1HMACAuthenticator.ToCanonicalizeHeaderValue(" foo\r\n  bar"));
        }

        [TestCase]
        public void TestToCanonicalizeHeaderValue2()
        {
            var val1 = V1HMACAuthenticator.ToCanonicalizeHeaderValue(" some value  \r\n \n with  some \r\n  spaces ");
            Assert.AreEqual("some value    with  some  spaces", val1);
        }

        [TestCase]
        public void TestToDataToSign()
        {
            var httpHeaders = new List<RequestHeader>
            {
                new RequestHeader("X-GCS-ServerMetaInfo", "{\"platformIdentifier\":\"Windows 7/6.1 Java/1.7 (Oracle Corporation; Java HotSpot(TM) 64-Bit Server VM; 1.7.0_45)\",\"sdkIdentifier\":\"1.0\"}"),
                new RequestHeader("Content-Type", "application/json"),
                new RequestHeader("X-GCS-ClientMetaInfo", "{\"foo\",\"bar\"}"),
                new RequestHeader("User-Agent", "Apache-HttpClient/4.3.4 (java 1.5)"),
                new RequestHeader("Date", "Mon, 07 Jul 2014 12:12:40 GMT")
            };
            var dataToSign = V1HMACAuthenticator.ToDataToSign(HttpMethod.Post, new Uri("http://localhost:8080/v1/9991/services%20bla/convert/amount?foo=bar&mies=no%20bar"), httpHeaders);

            const string expectedStart = "POST\napplication/json\n";
            const string expectedEnd = "x-gcs-clientmetainfo:{\"foo\",\"bar\"}\nx-gcs-servermetainfo:{\"platformIdentifier\":\"Windows 7/6.1 Java/1.7 (Oracle Corporation; Java HotSpot(TM) 64-Bit Server VM; 1.7.0_45)\",\"sdkIdentifier\":\"1.0\"}\n/v1/9991/services%20bla/convert/amount?foo=bar&mies=no bar\n";

            StringAssert.StartsWith(expectedStart, dataToSign);
            StringAssert.EndsWith(expectedEnd, dataToSign);
        }

        [TestCase]
        public void TestCreateAuthenticationSignature()
        {
            var authenticator = new V1HMACAuthenticator("apiKeyId", "secretApiKey");

            const string dataToSign = "DELETE\napplication/json\nFri, 06 Jun 2014 13:39:43 GMT\nx-gcs-clientmetainfo:processed header value\nx-gcs-customerheader:processed header value\nx-gcs-servermetainfo:processed header value\n/v1/9991/tokens/123456789\n";

            var authenticationSignature = authenticator.SignData(dataToSign);

            Assert.AreEqual("VfnXpPBQQoHZivTcAg0JvOWkhnzlPnaCPKpTQn/uMJM=", authenticationSignature);
        }

        [TestCase]
        public void TestCreateAuthenticationSignature2()
        {
            var authenticator = new V1HMACAuthenticator("EC36A74A98D21", "6Kj5HT0MQKC6D8eb7W3lTg71kVKVDSt1");

            const string dataToSign = "GET\n\nFri, 06 Jun 2014 13:39:43 GMT\n/v1/9991/tokens/123456789\n";

            var authenticationSignature = authenticator.SignData(dataToSign);

            Assert.AreEqual("9ond5EIN05dBXJGCLRK5om9pxHsyrh/12pZJ7bvmwNM=", authenticationSignature);
        }

        [TestCase]
        public async Task TestTotalMinimalExample()
        {
            var authenticator = new V1HMACAuthenticator("5e45c937b9db33ae", "I42Zf4pVnRdroHfuHnRiJjJ2B6+22h0yQt/R3nZR8Xg=");
            var httpHeaders = new List<RequestHeader>
            {
                new RequestHeader("User-Agent", "Apache-HttpClient/4.3.4 (java 1.5)"),
                new RequestHeader("Date", "Fri, 06 Jun 2014 13:39:43 GMT")
            };
            var signature = await authenticator.GetAuthorization(HttpMethod.Get, new Uri("http://api.connect.worldline-solutions.com:8080/v1/9991/tokens/123456789"), httpHeaders);
            Assert.AreEqual("GCS v1HMAC:5e45c937b9db33ae:J5LjfSBvrQNhu7gG0gvifZt+IWNDReGCmHmBmth6ueI=", signature);
        }

        [TestCase]
        public async Task TestTotalFullExample()
        {
            var authenticator = new V1HMACAuthenticator("5e45c937b9db33ae", "I42Zf4pVnRdroHfuHnRiJjJ2B6+22h0yQt/R3nZR8Xg=");
            var httpHeaders = new List<RequestHeader>
            {
                new RequestHeader("User-Agent", "Apache-HttpClient/4.3.4 (java 1.5)"),
                new RequestHeader("X-GCS-ServerMetaInfo", "processed header value"),
                new RequestHeader("X-GCS-ClientMetaInfo", "processed header value"),
                new RequestHeader("Content-Type", "application/json"),
                new RequestHeader("X-GCS-CustomerHeader", "processed header value"),
                new RequestHeader("Date", "Fri, 06 Jun 2014 13:39:43 GMT")
            };
            var signature = await authenticator.GetAuthorization(HttpMethod.Delete, new Uri("http://api.connect.worldline-solutions.com:8080/v1/9991/tokens/123456789"), httpHeaders);
            Assert.AreEqual("GCS v1HMAC:5e45c937b9db33ae:jGWLz3ouN4klE+SkqO5gO+KkbQNM06Rric7E3dcfmqw=", signature);
        }
    }
}
