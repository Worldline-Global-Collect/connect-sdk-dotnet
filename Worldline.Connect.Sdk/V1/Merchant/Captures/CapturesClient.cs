/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Captures
{
    /// <summary>
    /// Captures client. Thread-safe.
    /// </summary>
    public class CapturesClient : ApiResource
    {
        public CapturesClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/captures/{captureId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/captures/get.html">Get capture</a>
        /// </summary>
        /// <param name="captureId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>CaptureResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<CaptureResponse> Get(string captureId, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "captureId", captureId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/captures/{captureId}", pathContext);
            try
            {
                return await _communicator.Get<CaptureResponse>(
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
        /// Resource /{merchantId}/captures/{captureId}/refund
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/captures/refund.html">Create Refund</a>
        /// </summary>
        /// <param name="captureId">string</param>
        /// <param name="body">RefundRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>RefundResponse</returns>
        /// <exception cref="DeclinedRefundException">if the Worldline Global Collect platform declined / rejected the refund. The refund result will be available from the exception.</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<RefundResponse> Refund(string captureId, RefundRequest body, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "captureId", captureId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/captures/{captureId}/refund", pathContext);
            try
            {
                return await _communicator.Post<RefundResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        body,
                        context).ConfigureAwait(false);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<RefundErrorResponse>(e.Body);
                throw ExceptionFactory.CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }
    }
}
