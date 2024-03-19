/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.Json;
using Worldline.Connect.Sdk.Webhooks;

namespace Worldline.Connect.Sdk.V1.Webhooks
{
    /// <summary>
    /// Worldline Global Collect platform factory for several v1 webhooks components.
    /// </summary>
    public class V1WebhooksFactory
    {
        /// <summary>
        /// Creates a <see cref="WebhooksHelperBuilder"/> that will use the given <see cref="ISecretKeyStore"/>.
        /// </summary>
        public WebhooksHelperBuilder CreateHelperBuilder(ISecretKeyStore secretKeyStore)
        {
            return new WebhooksHelperBuilder().WithMarshaller(DefaultMarshaller.Instance).WithSecretKeyStore(secretKeyStore);
        }

        /// <summary>
        /// Creates a <see cref="WebhooksHelper"/> that will use the given <see cref="ISecretKeyStore"/>.
        /// </summary>
        public WebhooksHelper CreateHelper(ISecretKeyStore secretKeyStore)
        {
            return CreateHelperBuilder(secretKeyStore).Build();
        }
    }
}
