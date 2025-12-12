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

            Assert.AreEqual(iban, returnedToken.Iban);
            Assert.AreEqual(date, returnedToken.Date);
        }

        [TestCase]
        public void TestRETURNMAC()
        {
            const string retmac = "aaa";

            var json = DefaultMarshaller.Instance.Marshal(new CreateHostedCheckoutResponse { RETURNMAC = retmac });
            Assert.AreEqual("{\"RETURNMAC\":\"aaa\"}", json);

            var anObject = DefaultMarshaller.Instance.Unmarshal<CreateHostedCheckoutResponse>(json);
            Assert.NotNull(anObject.RETURNMAC);
        }

        [TestCase]
        public void TesRedirectData()
        {
            var redirectData = new RedirectData { RETURNMAC = "hello", RedirectURL = "world" };

            var json = DefaultMarshaller.Instance.Marshal(redirectData);
            Assert.AreEqual("{\"RETURNMAC\":\"hello\",\"redirectURL\":\"world\"}", json);

            var unmarshalledRedirectData = DefaultMarshaller.Instance.Unmarshal<RedirectData>(json);

            Assert.AreEqual(redirectData.RETURNMAC, unmarshalledRedirectData.RETURNMAC);
            Assert.AreEqual(redirectData.RedirectURL, unmarshalledRedirectData.RedirectURL);
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
            Assert.AreEqual("{\"paymentProducts\":[{\"id\":1}]}", json);

            var unmarshalledPaymentProducts = DefaultMarshaller.Instance.Unmarshal<PaymentProducts>(json);

            Assert.AreEqual(paymentProducts.ListOfPaymentProducts.Count, unmarshalledPaymentProducts.ListOfPaymentProducts.Count);
            Assert.AreEqual(paymentProducts.ListOfPaymentProducts[0].Id, unmarshalledPaymentProducts.ListOfPaymentProducts[0].Id);
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
