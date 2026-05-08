using NUnit.Framework;
using System;
using System.Collections.Generic;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.Json
{
    [TestFixture]
    public class DefaultMarshallerTest
    {
        [TestCase]
        public void TestUnmarshalWithExtraFields()
        {
            const string iban = "barbarbarbarfoo";
            var date = new DateTime(1999, 9, 29);
            var token = new ExtendedToken
            {
                Amount = 1337,
                Date = date,
                Iban = iban
            };

            var json = DefaultMarshaller.Instance.Marshal(token);
            var returnedToken = DefaultMarshaller.Instance.Unmarshal<JsonToken>(json);

            Assert.That(returnedToken.Iban, Is.EqualTo(iban));
            Assert.That(returnedToken.Date, Is.EqualTo(date));
        }

        [TestCase]
        public void TestRETURNMAC()
        {
            const string retmac = "aaa";

            var json = DefaultMarshaller.Instance.Marshal(new CreateHostedCheckoutResponse { RETURNMAC = retmac });
            Assert.That(json, Is.EqualTo("{\"RETURNMAC\":\"aaa\"}"));

            var anObject = DefaultMarshaller.Instance.Unmarshal<CreateHostedCheckoutResponse>(json);
            Assert.That(anObject.RETURNMAC, Is.Not.Null);
        }

        [TestCase]
        public void TesRedirectData()
        {
            var redirectData = new RedirectData { RETURNMAC = "hello", RedirectURL = "world" };

            var json = DefaultMarshaller.Instance.Marshal(redirectData);
            Assert.That(json, Is.EqualTo("{\"RETURNMAC\":\"hello\",\"redirectURL\":\"world\"}"));

            var unmarshalledRedirectData = DefaultMarshaller.Instance.Unmarshal<RedirectData>(json);

            Assert.That(unmarshalledRedirectData.RETURNMAC, Is.EqualTo(redirectData.RETURNMAC));
            Assert.That(unmarshalledRedirectData.RedirectURL, Is.EqualTo(redirectData.RedirectURL));
        }

        [TestCase]
        public void TestPaymentProducts()
        {
            var paymentProducts = new PaymentProducts
            {
                ListOfPaymentProducts = new List<PaymentProduct>
                {
                    new PaymentProduct { Id = 1 }
                }
            };

            var json = DefaultMarshaller.Instance.Marshal(paymentProducts);
            Assert.That(json, Is.EqualTo("{\"paymentProducts\":[{\"id\":1}]}"));

            var unmarshalledPaymentProducts = DefaultMarshaller.Instance.Unmarshal<PaymentProducts>(json);

            Assert.That(unmarshalledPaymentProducts.ListOfPaymentProducts.Count, Is.EqualTo(paymentProducts.ListOfPaymentProducts.Count));
            Assert.That(unmarshalledPaymentProducts.ListOfPaymentProducts[0].Id, Is.EqualTo(paymentProducts.ListOfPaymentProducts[0].Id));
        }
    }

    internal class JsonToken
    {
        public DateTime Date { get; set; } = new DateTime(1945, 4, 5);

        public string Iban { get; set; }
    }

    internal class ExtendedToken : JsonToken
    {
        public int Amount { get; set;}
    }
}
