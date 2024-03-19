using System;

namespace Worldline.Connect.Sdk.It
{
    public abstract class IntegrationTest
    {
        protected static CommunicatorConfiguration GetCommunicatorConfiguration()
        {
            if (ApiKeyId != null && SecretApiKey != null)
            {
                var configuration = Factory.CreateConfiguration(ApiKeyId, SecretApiKey);
                if (ApiEndpointUri != null)
                {
                    configuration.ApiEndpoint = new Uri(ApiEndpointUri);
                }
                return configuration;
            }
            throw new InvalidOperationException("Environment variables connect_api_apiKeyId and connect_api_secretApiKey must be set");
        }

        private static readonly string ApiKeyId = Environment.GetEnvironmentVariable("connect_api_apiKeyId");
        private static readonly string SecretApiKey = Environment.GetEnvironmentVariable("connect_api_secretApiKey");
        private static readonly string MerchantId = Environment.GetEnvironmentVariable("connect_api_merchantId");
        private static readonly string ApiEndpointUri = Environment.GetEnvironmentVariable("connect_api_endpointUri");

        protected static Client GetClient()
        {
            var configuration = GetCommunicatorConfiguration();
            return Factory.CreateClient(configuration).WithClientMetaInfo("{\"test\":\"test\"}");
        }

        protected static string GetMerchantId()
        {
            if (MerchantId != null)
            {
                return MerchantId;
            }
            throw new InvalidOperationException("Environment variable connect_api_merchantId must be set");
        }
    }
}
