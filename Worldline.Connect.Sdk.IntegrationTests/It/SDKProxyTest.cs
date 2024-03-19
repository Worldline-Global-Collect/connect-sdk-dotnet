using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.Util;
using Worldline.Connect.Sdk.V1.Merchant.Services;

namespace Worldline.Connect.Sdk.It
{
    public class SDKProxyTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for using a proxy configured throught SDK properties.
        /// </summary>
        public async Task Test()
        {
            var request = new ConvertAmountParams
            {
                Amount = 123L,
                Source = "USD",
                Target = "EUR"
            };

            using (var client = GetClient())
            {
                var services = client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Services;

                Assert.That(services, Is.TypeOf(typeof(ServicesClient)));
                var configuration = GetCommunicatorConfiguration();
                Assert.NotNull(configuration.Proxy);
                AssertProxyAndAuthentication(GetConnectionFromService(services), configuration.Proxy);

                var response = await services.ConvertAmount(request);

                Assert.NotNull(response.ConvertedAmount);
            }
        }

        private static DefaultConnection GetConnectionFromService(ServicesClient services)
        {
            var communicator = (Communicator)services.GetPrivateField("_communicator");
            return communicator.GetPrivateProperty<DefaultConnection>("Connection");
        }

        private static void AssertProxyAndAuthentication(DefaultConnection connection, Proxy proxy)
        {
            var httpClient = (HttpClient)connection.GetPrivateField("_httpClient");
            var handler = (HttpClientHandler)httpClient.GetPrivateField<HttpMessageInvoker>("handler");
            Assert.That(handler.UseProxy, Is.True);
            Assert.That(((WebProxy)handler.Proxy).Address, Is.EqualTo(proxy.Uri));
            Assert.That((NetworkCredential)handler.Proxy.Credentials, Is.Null);
            Assert.That(((NetworkCredential)handler.Proxy.Credentials).UserName, Is.EqualTo(proxy.Username));
            Assert.That(((NetworkCredential)handler.Proxy.Credentials).Password, Is.EqualTo(proxy.Password));
        }
    }
}
