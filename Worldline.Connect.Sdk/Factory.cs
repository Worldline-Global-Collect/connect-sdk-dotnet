using System;
using System.Collections.Generic;
using Worldline.Connect.Sdk.Authentication;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.Json;

namespace Worldline.Connect.Sdk
{
    /// <summary>
    /// Worldline Global Collect platform factory for several SDK components.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Creates a <see cref="CommunicatorConfiguration"/> based on the configuration values in
        /// your <c>app.conf</c> or <c>web.conf</c> file, <c>authorizationId</c> and <c>authorizationSecret</c>.
        /// </summary>
        /// <param name="authorizationId">The authorization id, e.g. the API key identifier.</param>
        /// <param name="authorizationSecret">The authorization secret, e.g. the secret API key.</param>
        /// <returns>The communicator configuration that can still be changed.</returns>
        public static CommunicatorConfiguration CreateConfiguration(string authorizationId, string authorizationSecret)
        {
            var configurationSection = System.Configuration.ConfigurationManager.GetSection("ConnectSDK") as CommunicatorConfigurationSection;
            if (configurationSection == null)
            {
                throw new InvalidOperationException("Unable to load configuration");
            }
            var configuration = new CommunicatorConfiguration(configurationSection);
            if (authorizationId != null)
            {
                configuration.AuthorizationId = authorizationId;
            }
            if (authorizationSecret != null)
            {
                configuration.AuthorizationSecret = authorizationSecret;
            }
            return configuration;
        }

        /// <summary>
        /// Creates a <see cref="CommunicatorConfiguration"/> based on the configuration
        /// values in <c>configurationDictionary</c>, <c>authorizationId</c> and <c>authorizationSecret</c>.
        /// </summary>
        /// <param name="configurationDictionary">Dictionary containing configuration.</param>
        /// <param name="authorizationId">The authorization id, e.g. the API key identifier.</param>
        /// <param name="authorizationSecret">The authorization secret, e.g. the secret API key.</param>
        /// <returns>The communicator configuration that can still be changed.</returns>
        public static CommunicatorConfiguration CreateConfiguration(IDictionary<string, string> configurationDictionary, string authorizationId, string authorizationSecret)
        {
            var configuration = new CommunicatorConfiguration(configurationDictionary);
            if (authorizationId != null)
            {
                configuration.AuthorizationId = authorizationId;
            }
            if (authorizationSecret != null)
            {
                configuration.AuthorizationSecret = authorizationSecret;
            }
            return configuration;
        }

        /// <summary>
        /// Creates a <see cref="CommunicatorBuilder"/> based on the configuration values in
        /// your <c>app.conf</c> or <c>web.conf</c> file, <c>authorizationId</c> and <c>authorizationSecret</c>.
        /// </summary>
        /// <param name="authorizationId">The authorization id, e.g. the API key identifier.</param>
        /// <param name="authorizationSecret">The authorization secret, e.g. the secret API key.</param>
        public static CommunicatorBuilder CreateCommunicatorBuilder(string authorizationId, string authorizationSecret)
        {
            var configuration = CreateConfiguration(authorizationId, authorizationSecret);
            return CreateCommunicatorBuilder(configuration);
        }

        /// <summary>
        /// Creates a <see cref="CommunicatorBuilder"/> based on the configuration
        /// values in <c>configurationDictionary</c>, <c>authorizationId</c> and <c>authorizationSecret</c>.
        /// </summary>
        /// <param name="configurationDictionary">Dictionary containing configuration.</param>
        /// <param name="authorizationId">The authorization id, e.g. the API key identifier.</param>
        /// <param name="authorizationSecret">The authorization secret, e.g. the secret API key.</param>
        public static CommunicatorBuilder CreateCommunicatorBuilder(IDictionary<string, string> configurationDictionary, string authorizationId, string authorizationSecret)
        {
            return CreateCommunicatorBuilder(CreateConfiguration(configurationDictionary, authorizationId, authorizationSecret));
        }

        /// <summary>
        /// Creates a <see cref="CommunicatorBuilder"/> based on the passed configuration.
        /// </summary>
        public static CommunicatorBuilder CreateCommunicatorBuilder(CommunicatorConfiguration configuration)
        {
            return new CommunicatorBuilder()
                    .WithApiEndpoint(configuration.ApiEndpoint)
                    .WithConnection(new DefaultConnection(
                            configuration.SocketTimeout,
                            // connect timeout not supported
                            configuration.MaxConnections,
                            configuration.Proxy,
                            configuration.HttpClientHandler
                    ))
                    .WithMetadataProvider(
                        new MetadataProviderBuilder(configuration.Integrator)
                        {
                            ShoppingCartExtension = configuration.ShoppingCartExtension
                        }.Build()
                    )
                    .WithAuthenticator(GetAuthenticator(configuration))
                    .WithMarshaller(DefaultMarshaller.Instance);
        }

        private static IAuthenticator GetAuthenticator(CommunicatorConfiguration configuration)
        {
            var authorizationType = configuration.AuthorizationType;
            if (authorizationType == AuthorizationType.V1HMAC) {
                return new V1HMACAuthenticator(configuration.ApiKeyId, configuration.SecretApiKey);
            }
            throw new InvalidOperationException("Unknown authorizationType " + authorizationType);
         }


        /// <summary>
        /// Creates a <see cref="Communicator"/> based on the configuration values in
        /// your <c>app.conf</c> or <c>web.conf</c> file, <c>authorizationId</c> and <c>authorizationSecret</c>.
        /// </summary>
        /// <param name="authorizationId">The authorization id, e.g. the API key identifier.</param>
        /// <param name="authorizationSecret">The authorization secret, e.g. the secret API key.</param>
        public static Communicator CreateCommunicator(string authorizationId, string authorizationSecret)
        {
            var configuration = CreateConfiguration(authorizationId, authorizationSecret);
            return CreateCommunicator(configuration);

        }

        /// <summary>
        /// Creates a <see cref="Communicator"/> based on the configuration values
        /// <c>configurationDictionary</c>, <c>authorizationId</c> and <c>authorizationSecret</c>.
        /// </summary>
        /// <param name="configurationDictionary">Dictionary containing configuration.</param>
        /// <param name="authorizationId">The authorization id, e.g. the API key identifier.</param>
        /// <param name="authorizationSecret">The authorization secret, e.g. the secret API key.</param>
        public static Communicator CreateCommunicator(IDictionary<string, string> configurationDictionary, string authorizationId, string authorizationSecret)
        {
            var configuration = CreateConfiguration(configurationDictionary, authorizationId, authorizationSecret);
            return CreateCommunicator(configuration);
        }

        /// <summary>
        /// Creates a <see cref="Communicator"/> based on the passed configuration.
        /// </summary>
        public static Communicator CreateCommunicator(CommunicatorConfiguration configuration)
        {
            var communicatorBuilder = CreateCommunicatorBuilder(configuration);
            return communicatorBuilder.Build();
        }

        /// <summary>
        /// Creates a <see cref="Communicator"/> based on the passed fields.
        /// </summary>
        /// <param name="apiEndpoint">The payment platform API endpoint URI to use.</param>
        /// <param name="connection">The <see cref="IConnection"/> to use.</param>
        /// <param name="authenticator">The <see cref="IAuthenticator"/> to use.</param>
        /// <param name="metadataProvider">The <see cref="MetadataProvider"/> to use.</param>
        public static Communicator CreateCommunicator(Uri apiEndpoint, IConnection connection, IAuthenticator authenticator, MetadataProvider metadataProvider)
        {
            return new Communicator(apiEndpoint, connection, authenticator, metadataProvider, DefaultMarshaller.Instance);
        }

        /// <summary>
        /// Creates a <see cref="Client"/> based on the configuration values in
        /// your <c>app.conf</c> or <c>web.conf</c> file, <c>authorizationId</c> and <c>authorizationSecret</c>.
        /// </summary>
        /// <param name="authorizationId">The authorization id, e.g. the API key identifier.</param>
        /// <param name="authorizationSecret">The authorization secret, e.g. the secret API key.</param>
        public static Client CreateClient(string authorizationId, string authorizationSecret)
        {
            return CreateClient(CreateCommunicator(authorizationId, authorizationSecret));
        }

        /// <summary>
        /// Creates a <see cref="Client"/> based on the configuration values in
        /// <c>configurationDictionary</c>, <c>authorizationId</c> and <c>authorizationSecret</c>.
        /// </summary>
        /// <param name="configurationDictionary">Dictionary containing configuration.</param>
        /// <param name="authorizationId">The authorization id, e.g. the API key identifier.</param>
        /// <param name="authorizationSecret">The authorization secret, e.g. the secret API key.</param>
        public static Client CreateClient(IDictionary<string, string> configurationDictionary, string authorizationId, string authorizationSecret)
        {
            return CreateClient(CreateCommunicator(configurationDictionary, authorizationId, authorizationSecret));
        }

        /// <summary>
        /// Creates a <see cref="Client"/> based on the passed configuration.
        /// </summary>
        public static Client CreateClient(CommunicatorConfiguration configuration)
        {
            return CreateClient(CreateCommunicator(configuration));
        }

        /// <summary>
        /// Creates a <see cref="Client"/> based on the passed fields.
        /// </summary>
        /// <param name="apiEndpoint">The payment platform API endpoint URI to use.</param>
        /// <param name="connection">The <see cref="IConnection"/> to use.</param>
        /// <param name="authenticator">The <see cref="IAuthenticator"/> to use.</param>
        /// <param name="metadataProvider">The <see cref="MetadataProvider"/> to use.</param>
        public static Client CreateClient(Uri apiEndpoint, IConnection connection, IAuthenticator authenticator, MetadataProvider metadataProvider)
        {
            return CreateClient(CreateCommunicator(apiEndpoint, connection, authenticator, metadataProvider));
        }

        /// <summary>
        /// Creates a <see cref="Client"/> based on the passed communicator.
        /// </summary>
        /// <param name="communicator">The shared communicator to use.</param>
        public static Client CreateClient(Communicator communicator)
        {
            return new Client(communicator);
        }
    }
}
