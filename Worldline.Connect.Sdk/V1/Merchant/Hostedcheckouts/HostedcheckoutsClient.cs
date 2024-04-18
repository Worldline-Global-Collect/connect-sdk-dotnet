/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Hostedcheckouts
{
    /// <summary>
    /// Hostedcheckouts client. Thread-safe.
    /// </summary>
    public class HostedcheckoutsClient : ApiResource
    {
        public HostedcheckoutsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/hostedcheckouts
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/hostedcheckouts/create.html">Create hosted checkout</a>
        /// </summary>
        /// <param name="body">CreateHostedCheckoutRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>CreateHostedCheckoutResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<CreateHostedCheckoutResponse> Create(CreateHostedCheckoutRequest body, CallContext context = null)
        {
            var uri = InstantiateUri("/v1/{merchantId}/hostedcheckouts", null);
            try
            {
                return await _communicator.Post<CreateHostedCheckoutResponse>(
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
        /// Resource /{merchantId}/hostedcheckouts/{hostedCheckoutId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/hostedcheckouts/get.html">Get hosted checkout status</a>
        /// </summary>
        /// <param name="hostedCheckoutId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>GetHostedCheckoutResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<GetHostedCheckoutResponse> Get(string hostedCheckoutId, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "hostedCheckoutId", hostedCheckoutId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/hostedcheckouts/{hostedCheckoutId}", pathContext);
            try
            {
                return await _communicator.Get<GetHostedCheckoutResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        context).ConfigureAwait(false);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                throw ExceptionFactory.CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/hostedcheckouts/{hostedCheckoutId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/hostedcheckouts/delete.html">Delete hosted checkout</a>
        /// </summary>
        /// <param name="hostedCheckoutId">string</param>
        /// <param name="context">CallContext</param>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task Delete(string hostedCheckoutId, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "hostedCheckoutId", hostedCheckoutId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/hostedcheckouts/{hostedCheckoutId}", pathContext);
            try
            {
                await _communicator.Delete<object>(
                        uri,
                        ClientHeaders,
                        null,
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
