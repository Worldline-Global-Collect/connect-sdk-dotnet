using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using Worldline.Connect.Sdk.Authentication;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.Json;
using Worldline.Connect.Sdk.Util;

namespace Worldline.Connect.Sdk
{
    [TestFixture]
    public class FactoryTest
    {
        public const string ApiKeyId = "someKey";
        public const string SecretApiKey = "someSecret";

        public static readonly IDictionary<string,string> Dict = new Dictionary<string, string> {
                {"connect.api.integrator", "Worldline"},
                {"connect.api.endpoint.host", "api.preprod.connect.worldline-solutions.com" },
                {"connect.api.authorizationType", "v1HMAC"},
                {"connect.api.socketTimeout", "-1"},
                {"connect.api.connectTimeout", "-1"},
                {"connect.api.maxConnections", "100"}
            };

        [TestCase]
        public void TestCreateConfiguration()
        {
            var configuration = Factory.CreateConfiguration(Dict, ApiKeyId, SecretApiKey);
            Assert.That(configuration.ApiEndpoint, Is.EqualTo(new Uri("https://api.preprod.connect.worldline-solutions.com")));
            Assert.That(configuration.AuthorizationType, Is.EqualTo(AuthorizationType.V1HMAC));
            Assert.That(configuration.ConnectTimeout, Is.Null);
            Assert.That(configuration.SocketTimeout, Is.Null);
            Assert.That(configuration.MaxConnections, Is.EqualTo(100));
            Assert.That(configuration.ApiKeyId, Is.EqualTo(ApiKeyId));
            Assert.That(configuration.SecretApiKey, Is.EqualTo(SecretApiKey));
        }

        [TestCase]
        public void TestCreateCommunicator()
        {
            var communicator = Factory.CreateCommunicator(Dict, ApiKeyId, SecretApiKey);

            Assert.That(communicator.Marshaller, Is.SameAs(DefaultMarshaller.Instance));

            var connection = communicator.Connection;
            Assert.That(connection, Is.InstanceOf<DefaultConnection>());
            //DefaultConnectionTest.assertConnection((DefaultConnection) connection, -1, -1, 100, null);

            var authenticator = communicator.Authenticator;
            Assert.That(authenticator, Is.InstanceOf<V1HMACAuthenticator>());
            Assert.That(authenticator.GetPrivateField(typeof(V1HMACAuthenticator), "_apiKeyId"), Is.EqualTo(ApiKeyId));
            Assert.That(authenticator.GetPrivateField(typeof(V1HMACAuthenticator), "_secretApiKey"), Is.EqualTo(SecretApiKey));

            var metadataProvider = communicator.MetadataProvider;
            Assert.That(metadataProvider.GetType(), Is.EqualTo(typeof(MetadataProvider)));
            var requestHeaders = metadataProvider.ServerMetadataHeaders;
            Assert.That(requestHeaders.Count(), Is.EqualTo(1));
            var requestHeader = requestHeaders.ElementAt(0);
            Assert.That(requestHeader.Name, Is.EqualTo("X-GCS-ServerMetaInfo"));
        }
    }
}
