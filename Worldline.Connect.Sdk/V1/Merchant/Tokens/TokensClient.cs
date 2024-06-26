/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Tokens
{
    /// <summary>
    /// Tokens client. Thread-safe.
    /// </summary>
    public class TokensClient : ApiResource
    {
        public TokensClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/tokens
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/tokens/create.html">Create token</a>
        /// </summary>
        /// <param name="body">CreateTokenRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>CreateTokenResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<CreateTokenResponse> Create(CreateTokenRequest body, CallContext context = null)
        {
            var uri = InstantiateUri("/v1/{merchantId}/tokens", null);
            try
            {
                return await _communicator.Post<CreateTokenResponse>(
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
        /// Resource /{merchantId}/tokens/{tokenId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/tokens/get.html">Get token</a>
        /// </summary>
        /// <param name="tokenId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>TokenResponse</returns>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code 409)</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code 400)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code 403)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code 404, 409 or 410)</exception>
        /// <exception cref="PlatformException">if something went wrong at the Worldline Global Collect platform,
        ///            the Worldline Global Collect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code 500, 502 or 503)</exception>
        /// <exception cref="ApiException">if the Worldline Global Collect platform returned any other error</exception>
        public async Task<TokenResponse> Get(string tokenId, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "tokenId", tokenId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/tokens/{tokenId}", pathContext);
            try
            {
                return await _communicator.Get<TokenResponse>(
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
        /// Resource /{merchantId}/tokens/{tokenId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/tokens/update.html">Update token</a>
        /// </summary>
        /// <param name="tokenId">string</param>
        /// <param name="body">UpdateTokenRequest</param>
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
        public async Task Update(string tokenId, UpdateTokenRequest body, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "tokenId", tokenId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/tokens/{tokenId}", pathContext);
            try
            {
                await _communicator.Put<object>(
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
        /// Resource /{merchantId}/tokens/{tokenId}
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/tokens/delete.html">Delete token</a>
        /// </summary>
        /// <param name="tokenId">string</param>
        /// <param name="query">DeleteTokenParams</param>
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
        public async Task Delete(string tokenId, DeleteTokenParams query, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "tokenId", tokenId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/tokens/{tokenId}", pathContext);
            try
            {
                await _communicator.Delete<object>(
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
        /// Resource /{merchantId}/tokens/{tokenId}/approvesepadirectdebit
        /// - <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/tokens/approvesepadirectdebit.html">Approve SEPA DD mandate</a>
        /// </summary>
        /// <param name="tokenId">string</param>
        /// <param name="body">ApproveTokenRequest</param>
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
        public async Task Approvesepadirectdebit(string tokenId, ApproveTokenRequest body, CallContext context = null)
        {
            var pathContext = new Dictionary<string, string>
            {
                { "tokenId", tokenId }
            };
            var uri = InstantiateUri("/v1/{merchantId}/tokens/{tokenId}/approvesepadirectdebit", pathContext);
            try
            {
                await _communicator.Post<object>(
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
