/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Hostedmandatemanagements
{
    /// <summary>
    /// Hostedmandatemanagements client. Thread-safe.
    /// </summary>
    public class HostedmandatemanagementsClient : ApiResource
    {
        public HostedmandatemanagementsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/hostedmandatemanagements
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/hostedmandatemanagements/create.html">Create hosted mandate management</a>
        /// </summary>
        /// <param name="body">CreateHostedMandateManagementRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>CreateHostedMandateManagementResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<CreateHostedMandateManagementResponse> Create(CreateHostedMandateManagementRequest body, CallContext context = null)
        {
            var uri = InstantiateUri("/v1/{merchantId}/hostedmandatemanagements", null);
            try
            {
                return await _communicator.Post<CreateHostedMandateManagementResponse>(
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
        /// Resource /{merchantId}/hostedmandatemanagements/{hostedMandateManagementId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/hostedmandatemanagements/get.html">Get hosted mandate management status</a>
        /// </summary>
        /// <param name="hostedMandateManagementId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>GetHostedMandateManagementResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<GetHostedMandateManagementResponse> Get(string hostedMandateManagementId, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "hostedMandateManagementId", hostedMandateManagementId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/hostedmandatemanagements/{hostedMandateManagementId}", pathContext);
            try
            {
                return await _communicator.Get<GetHostedMandateManagementResponse>(
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
