/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;
using System.Collections.Generic;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.Json;
using Worldline.Connect.Sdk.V1.Domain;
using Worldline.Connect.Sdk.Webhooks;

namespace Worldline.Connect.Sdk.V1.Webhooks
{
    /// <summary>
    /// Worldline Global Collect platform webhooks helper. Thread-safe.
    /// </summary>
    public class WebhooksHelper
    {
        private readonly IMarshaller _marshaller;
        private readonly SignatureValidator _signatureValidator;

        public WebhooksHelper(IMarshaller marshaller, ISecretKeyStore secretKeyStore)
        {
            _marshaller = marshaller ?? throw new ArgumentException("marshaller is required");
            _signatureValidator = new SignatureValidator(secretKeyStore);
        }

        /// <summary>
        /// Unmarshals the given body, while also validating it using the given request headers.
        /// </summary>
        /// <exception cref="SignatureValidationException">If the body could not be validated successfully.</exception>
        /// <exception cref="ApiVersionMismatchException"> If the resulting event has an API version that this version of the SDK does not support.</exception>
        public WebhooksEvent Unmarshal(string body, IEnumerable<IRequestHeader> requestHeaders)
        {
            _signatureValidator.Validate(body, requestHeaders);

            var unmarshalledEvent = _marshaller.Unmarshal<WebhooksEvent>(body);
            ValidateApiVersion(unmarshalledEvent);
            return unmarshalledEvent;
        }

        /// <summary>
        /// Unmarshals the given body, while also validating it using the given request headers.
        /// </summary>
        /// <exception cref="SignatureValidationException">If the body could not be validated successfully.</exception>
        /// <exception cref="ApiVersionMismatchException"> If the resulting event has an API version that this version of the SDK does not support.</exception>
        public WebhooksEvent Unmarshal(byte[] body, IEnumerable<IRequestHeader> requestHeaders)
        {
            _signatureValidator.Validate(body, requestHeaders);

            var unmarshalledEvent = _marshaller.Unmarshal<WebhooksEvent>(StringUtils.Encoding.GetString(body));
            ValidateApiVersion(unmarshalledEvent);
            return unmarshalledEvent;
        }

        private static void ValidateApiVersion(WebhooksEvent unmarshalledEvent)
        {
            if (!"v1".Equals(unmarshalledEvent.ApiVersion))
            {
                throw new ApiVersionMismatchException(unmarshalledEvent.ApiVersion, "v1");
            }
        }
    }
}
