using NUnit.Framework;
using System;
using System.Collections.Generic;
using Worldline.Connect.Sdk.Authentication;

namespace Worldline.Connect.Sdk
{
    [TestFixture]
    public class CommunicatorConfigurationTest
    {
        private const string AuthType = "v1HMAC";

        [TestCase]
        public void TestConstructFromPropertiesWithoutProxy()
        {
            var configuration = CreateBasicConfiguration();

            AssertBasicConfigurationSettings(configuration);
            Assert.AreEqual(CommunicatorConfiguration.DefaultMaxConnections, configuration.MaxConnections);
            Assert.Null(configuration.AuthorizationId);
            Assert.Null(configuration.AuthorizationSecret);

            Assert.Null(configuration.Proxy);
            Assert.Null(configuration.ProxyUri);
            Assert.Null(configuration.ProxyUserName);
            Assert.Null(configuration.ProxyPassword);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithProxyWithoutAuthentication()
        {
            var configuration = CreateBasicConfiguration()
                .WithProxyUri(new Uri("http://proxy.example.org:3128"));

            AssertBasicConfigurationSettings(configuration);
            Assert.AreEqual(CommunicatorConfiguration.DefaultMaxConnections, configuration.MaxConnections);
            Assert.Null(configuration.AuthorizationId);
            Assert.Null(configuration.AuthorizationSecret);

            var proxy = configuration.Proxy;
            Assert.NotNull(proxy);
            AssertBasicProxySettings(proxy);
            Assert.Null(proxy.Username);
            Assert.Null(proxy.Password);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithProxyWithAuthentication()
        {
            var configuration = CreateBasicConfiguration()
                .WithProxyUri(new Uri("http://proxy.example.org:3128"))
                .WithProxyUserName("connect-username")
                .WithProxyPassword("connect-password");

            AssertBasicConfigurationSettings(configuration);
            Assert.AreEqual(CommunicatorConfiguration.DefaultMaxConnections, configuration.MaxConnections);
            Assert.Null(configuration.AuthorizationId);
            Assert.Null(configuration.AuthorizationSecret);

            var proxy = configuration.Proxy;
            Assert.NotNull(proxy);
            AssertBasicProxySettings(proxy);
            Assert.AreEqual("connect-username", proxy.Username);
            Assert.AreEqual("connect-password", proxy.Password);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithMaxConnections()
        {
            var configuration = CreateBasicConfiguration()
                .WithMaxConnections(100);

            AssertBasicConfigurationSettings(configuration);
            Assert.AreEqual(100, configuration.MaxConnections);
            Assert.Null(configuration.AuthorizationId);
            Assert.Null(configuration.AuthorizationSecret);

            // In original tests was null, but not anymore, because of app config configuration
            //Assert.Null(configuration.ProxyConfiguration);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithHostAndScheme()
        {
            var properties = new Dictionary<string, string>
            {
                ["connect.api.endpoint.scheme"] = "http",
                ["connect.api.endpoint.host"] = "api.preprod.connect.worldline-solutions.com",
                ["connect.api.authorizationType"] = AuthType,
                ["connect.api.connectTimeout"] = "20000",
                ["connect.api.socketTimeout"] = "10000"
            };

            var configuration = new CommunicatorConfiguration(properties);

            Assert.AreEqual(new Uri("http://api.preprod.connect.worldline-solutions.com"), configuration.ApiEndpoint);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithHostAndPort()
        {
            var properties = new Dictionary<string, string>
            {
                ["connect.api.endpoint.port"] = "8443",
                ["connect.api.endpoint.host"] = "api.preprod.connect.worldline-solutions.com",
                ["connect.api.authorizationType"] = AuthType,
                ["connect.api.connectTimeout"] = "20000",
                ["connect.api.socketTimeout"] = "10000"
            };

            var configuration = new CommunicatorConfiguration(properties);

            Assert.AreEqual(new Uri("https://api.preprod.connect.worldline-solutions.com:8443"), configuration.ApiEndpoint);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithHostSchemeAndPort()
        {
            var properties = new Dictionary<string, string>
            {
                ["connect.api.endpoint.port"] = "8080",
                ["connect.api.endpoint.host"] = "api.preprod.connect.worldline-solutions.com",
                ["connect.api.endpoint.scheme"] = "http",
                ["connect.api.authorizationType"] = AuthType,
                ["connect.api.connectTimeout"] = "20000",
                ["connect.api.socketTimeout"] = "10000"
            };

            var configuration = new CommunicatorConfiguration(properties);

            Assert.AreEqual(new Uri("http://api.preprod.connect.worldline-solutions.com:8080"), configuration.ApiEndpoint);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithIPv6Host()
        {
            var properties = new Dictionary<string, string>
            {
                ["connect.api.endpoint.host"] = "::1",
                ["connect.api.authorizationType"] = AuthType,
                ["connect.api.connectTimeout"] = "20000",
                ["connect.api.socketTimeout"] = "10000"
            };

            var configuration = new CommunicatorConfiguration(properties);

            Assert.AreEqual(new Uri("https://[::1]"), configuration.ApiEndpoint);
        }

        private static CommunicatorConfiguration CreateBasicConfiguration()
        {
            return new CommunicatorConfiguration()
                .WithApiEndpoint(new Uri("https://api.preprod.connect.worldline-solutions.com"))
                .WithAuthorizationType(AuthorizationType.V1HMAC)
                .WithConnectTimeout(20000)
                .WithSocketTimeout(10000);
        }

        private static void AssertBasicConfigurationSettings(CommunicatorConfiguration configuration)
        {
            Assert.AreEqual(new Uri("https://api.preprod.connect.worldline-solutions.com"), configuration.ApiEndpoint);
            Assert.AreEqual(AuthorizationType.V1HMAC, configuration.AuthorizationType);
            Assert.AreEqual(20000, configuration.ConnectTimeout?.TotalMilliseconds);
            Assert.AreEqual(10000, configuration.SocketTimeout?.TotalMilliseconds);
        }

        /// <summary>
        /// Checks validity of basic proxy settings of a proxy with uri http://proxy.example.org:3128.
        /// </summary>
        /// <param name="proxy">Proxy.</param>
        private static void AssertBasicProxySettings(Proxy proxy)
        {
            Assert.AreEqual("http", proxy.Uri.Scheme);
            Assert.AreEqual("proxy.example.org", proxy.Uri.Host);
            Assert.AreEqual(3128, proxy.Uri.Port);
        }
    }
}
