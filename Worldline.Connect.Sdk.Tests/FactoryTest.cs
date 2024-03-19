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
            Assert.AreEqual(new Uri("https://api.preprod.connect.worldline-solutions.com"), configuration.ApiEndpoint);
            Assert.AreEqual(AuthorizationType.V1HMAC, configuration.AuthorizationType);
            Assert.AreEqual(null, configuration.ConnectTimeout);
            Assert.AreEqual(null, configuration.SocketTimeout);
            Assert.AreEqual(100, configuration.MaxConnections);
            Assert.AreEqual(ApiKeyId, configuration.ApiKeyId);
            Assert.AreEqual(SecretApiKey, configuration.SecretApiKey);
        }

        [TestCase]
        public void TestCreateCommunicator()
        {
            var communicator = Factory.CreateCommunicator(Dict, ApiKeyId, SecretApiKey);

            Assert.AreSame(DefaultMarshaller.Instance, communicator.Marshaller);

            var connection = communicator.Connection;
            Assert.True(connection is DefaultConnection);
            //DefaultConnectionTest.assertConnection((DefaultConnection) connection, -1, -1, 100, null);

            var authenticator = communicator.Authenticator;
            Assert.True(authenticator is V1HMACAuthenticator);
            Assert.AreEqual(ApiKeyId, authenticator.GetPrivateField(typeof(V1HMACAuthenticator), "_apiKeyId"));
            Assert.AreEqual(SecretApiKey, authenticator.GetPrivateField(typeof(V1HMACAuthenticator), "_secretApiKey"));

            var metadataProvider = communicator.MetadataProvider;
            Assert.AreEqual(typeof(MetadataProvider), metadataProvider.GetType());
            var requestHeaders = metadataProvider.ServerMetadataHeaders;
            Assert.AreEqual(1, requestHeaders.Count());
            var requestHeader = requestHeaders.ElementAt(0);
            Assert.AreEqual("X-GCS-ServerMetaInfo", requestHeader.Name);
        }
    }
}
