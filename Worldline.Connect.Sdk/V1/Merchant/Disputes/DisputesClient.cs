/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Disputes
{
    /// <summary>
    /// Disputes client. Thread-safe.
    /// </summary>
    public class DisputesClient : ApiResource
    {
        public DisputesClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/disputes/{disputeId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/disputes/get.html">Get dispute</a>
        /// </summary>
        /// <param name="disputeId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>DisputeResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<DisputeResponse> Get(string disputeId, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "disputeId", disputeId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/disputes/{disputeId}", pathContext);
            try
            {
                return await _communicator.Get<DisputeResponse>(
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
        /// Resource /{merchantId}/disputes/{disputeId}/submit
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/disputes/submit.html">Submit dispute</a>
        /// </summary>
        /// <param name="disputeId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>DisputeResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<DisputeResponse> Submit(string disputeId, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "disputeId", disputeId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/disputes/{disputeId}/submit", pathContext);
            try
            {
                return await _communicator.Post<DisputeResponse>(
                        uri,
                        ClientHeaders,
                        null,
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
        /// Resource /{merchantId}/disputes/{disputeId}/cancel
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/disputes/cancel.html">Cancel dispute</a>
        /// </summary>
        /// <param name="disputeId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>DisputeResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<DisputeResponse> Cancel(string disputeId, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "disputeId", disputeId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/disputes/{disputeId}/cancel", pathContext);
            try
            {
                return await _communicator.Post<DisputeResponse>(
                        uri,
                        ClientHeaders,
                        null,
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
        /// Resource /{merchantId}/disputes/{disputeId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/fileserviceapi/v1/en_US/dotnet/disputes/uploadFile.html">Upload File</a>
        /// </summary>
        /// <param name="disputeId">string</param>
        /// <param name="body">UploadFileRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>UploadDisputeFileResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<UploadDisputeFileResponse> UploadFile(string disputeId, UploadFileRequest body, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "disputeId", disputeId }
            };
            var uri = InstantiateUri("/files/v1/{merchantId}/disputes/{disputeId}", pathContext);
            try
            {
                return await _communicator.Post<UploadDisputeFileResponse>(
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
