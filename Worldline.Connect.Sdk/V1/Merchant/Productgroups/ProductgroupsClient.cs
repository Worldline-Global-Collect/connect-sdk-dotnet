/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Productgroups
{
    /// <summary>
    /// Productgroups client. Thread-safe.
    /// </summary>
    public class ProductgroupsClient : ApiResource
    {
        public ProductgroupsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/productgroups
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/productgroups/find.html">Get payment product groups</a>
        /// </summary>
        /// <param name="query">FindProductgroupsParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProductGroups</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<PaymentProductGroups> Find(FindProductgroupsParams query, CallContext context = null)
        {
            var uri = InstantiateUri("/v1/{merchantId}/productgroups", null);
            try
            {
                return await _communicator.Get<PaymentProductGroups>(
                        uri,
                        ClientHeaders,
                        query,
                        context).ConfigureAwait(false);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                throw ExceptionFactory.CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/productgroups/{paymentProductGroupId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/productgroups/get.html">Get payment product group</a>
        /// </summary>
        /// <param name="paymentProductGroupId">string</param>
        /// <param name="query">GetProductgroupParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProductGroupResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<PaymentProductGroupResponse> Get(string paymentProductGroupId, GetProductgroupParams query, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "paymentProductGroupId", paymentProductGroupId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/productgroups/{paymentProductGroupId}", pathContext);
            try
            {
                return await _communicator.Get<PaymentProductGroupResponse>(
                        uri,
                        ClientHeaders,
                        query,
                        context).ConfigureAwait(false);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                throw ExceptionFactory.CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/productgroups/{paymentProductGroupId}/deviceFingerprint
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/productgroups/deviceFingerprint.html">Get device fingerprint</a>
        /// </summary>
        /// <param name="paymentProductGroupId">string</param>
        /// <param name="body">DeviceFingerprintRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>DeviceFingerprintResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<DeviceFingerprintResponse> DeviceFingerprint(string paymentProductGroupId, DeviceFingerprintRequest body, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "paymentProductGroupId", paymentProductGroupId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/productgroups/{paymentProductGroupId}/deviceFingerprint", pathContext);
            try
            {
                return await _communicator.Post<DeviceFingerprintResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        body,
                        context).ConfigureAwait(false);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                throw ExceptionFactory.CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }
    }
}
