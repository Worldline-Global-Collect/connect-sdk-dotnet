/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;
using Worldline.Connect.Sdk.Json;
using Worldline.Connect.Sdk.Webhooks;

namespace Worldline.Connect.Sdk.V1.Webhooks
{
    /// <summary>
    /// Builder for a <see cref="WebhooksHelper"/> object.
    /// </summary>
    public class WebhooksHelperBuilder
    {
        private IMarshaller Marshaller {get; set;}
        private ISecretKeyStore SecretKeyStore { get; set;}

        /// <summary>
        /// Sets the <see cref="IMarshaller"/> to use.
        /// </summary>
        public WebhooksHelperBuilder WithMarshaller(IMarshaller marshaller) {
            Marshaller = marshaller;
            return this;
        }

        /// <summary>
        /// Sets the <see cref="ISecretKeyStore"/> to use.
        /// </summary>
        public WebhooksHelperBuilder WithSecretKeyStore(ISecretKeyStore secretKeyStore) {
            SecretKeyStore = secretKeyStore;
            return this;
        }

        /// <summary>
        /// Creates a fully initialized <see cref="WebhooksHelper"/> object.
        /// </summary>
        /// <exception cref="ArgumentException"> If Not all required arguments are set.</exception>
        public WebhooksHelper Build()
        {
            return new WebhooksHelper(Marshaller, SecretKeyStore);
        }
    }
}
