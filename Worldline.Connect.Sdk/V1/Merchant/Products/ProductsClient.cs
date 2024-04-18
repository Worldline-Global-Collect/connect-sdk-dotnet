/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Products
{
    /// <summary>
    /// Products client. Thread-safe.
    /// </summary>
    public class ProductsClient : ApiResource
    {
        public ProductsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/products
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/products/find.html">Get payment products</a>
        /// </summary>
        /// <param name="query">FindProductsParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProducts</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<PaymentProducts> Find(FindProductsParams query, CallContext context = null)
        {
            var uri = InstantiateUri("/v1/{merchantId}/products", null);
            try
            {
                return await _communicator.Get<PaymentProducts>(
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
        /// Resource /{merchantId}/products/{paymentProductId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/products/get.html">Get payment product</a>
        /// </summary>
        /// <param name="paymentProductId">int?</param>
        /// <param name="query">GetProductParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProductResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<PaymentProductResponse> Get(int? paymentProductId, GetProductParams query, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "paymentProductId", paymentProductId.ToString() }
            };
            var uri = InstantiateUri("/v1/{merchantId}/products/{paymentProductId}", pathContext);
            try
            {
                return await _communicator.Get<PaymentProductResponse>(
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
        /// Resource /{merchantId}/products/{paymentProductId}/directory
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/products/directory.html">Get payment product directory</a>
        /// </summary>
        /// <param name="paymentProductId">int?</param>
        /// <param name="query">DirectoryParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>Directory</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<Directory> Directory(int? paymentProductId, DirectoryParams query, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "paymentProductId", paymentProductId.ToString() }
            };
            var uri = InstantiateUri("/v1/{merchantId}/products/{paymentProductId}/directory", pathContext);
            try
            {
                return await _communicator.Get<Directory>(
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
        /// Resource /{merchantId}/products/{paymentProductId}/customerDetails
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/products/customerDetails.html">Get customer details</a>
        /// </summary>
        /// <param name="paymentProductId">int?</param>
        /// <param name="body">GetCustomerDetailsRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>GetCustomerDetailsResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<GetCustomerDetailsResponse> CustomerDetails(int? paymentProductId, GetCustomerDetailsRequest body, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "paymentProductId", paymentProductId.ToString() }
            };
            var uri = InstantiateUri("/v1/{merchantId}/products/{paymentProductId}/customerDetails", pathContext);
            try
            {
                return await _communicator.Post<GetCustomerDetailsResponse>(
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

        /// <summary>
        /// Resource /{merchantId}/products/{paymentProductId}/deviceFingerprint
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/products/deviceFingerprint.html">Get device fingerprint</a>
        /// </summary>
        /// <param name="paymentProductId">int?</param>
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
        public async Task<DeviceFingerprintResponse> DeviceFingerprint(int? paymentProductId, DeviceFingerprintRequest body, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "paymentProductId", paymentProductId.ToString() }
            };
            var uri = InstantiateUri("/v1/{merchantId}/products/{paymentProductId}/deviceFingerprint", pathContext);
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

        /// <summary>
        /// Resource /{merchantId}/products/{paymentProductId}/networks
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/products/networks.html">Get payment product networks</a>
        /// </summary>
        /// <param name="paymentProductId">int?</param>
        /// <param name="query">NetworksParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProductNetworksResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<PaymentProductNetworksResponse> Networks(int? paymentProductId, NetworksParams query, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "paymentProductId", paymentProductId.ToString() }
            };
            var uri = InstantiateUri("/v1/{merchantId}/products/{paymentProductId}/networks", pathContext);
            try
            {
                return await _communicator.Get<PaymentProductNetworksResponse>(
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
        /// Resource /{merchantId}/products/{paymentProductId}/sessions
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/products/sessions.html">Create session for payment product</a>
        /// </summary>
        /// <param name="paymentProductId">int?</param>
        /// <param name="body">CreatePaymentProductSessionRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>CreatePaymentProductSessionResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<CreatePaymentProductSessionResponse> Sessions(int? paymentProductId, CreatePaymentProductSessionRequest body, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "paymentProductId", paymentProductId.ToString() }
            };
            var uri = InstantiateUri("/v1/{merchantId}/products/{paymentProductId}/sessions", pathContext);
            try
            {
                return await _communicator.Post<CreatePaymentProductSessionResponse>(
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
