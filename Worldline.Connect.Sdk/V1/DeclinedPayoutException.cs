/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Net;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1
{
    /// <summary>
    /// Represents an error response from a payout call.
    /// </summary>
    public class DeclinedPayoutException : DeclinedTransactionException
    {
        /// <summary>
        /// Gets the result of creating a payout if available, otherwise <c>null</c>.
        /// </summary>
        public PayoutResult PayoutResult => _response?.PayoutResult;

        public DeclinedPayoutException(HttpStatusCode statusCode, string responseBody, PayoutErrorResponse response)
            : base(BuildMessage(response), statusCode, responseBody, response?.ErrorId, response?.Errors)
        {
            _response = response;
        }

        private readonly PayoutErrorResponse _response;

        private static string BuildMessage(PayoutErrorResponse response)
        {
            var payoutResult = response?.PayoutResult;
            if (payoutResult != null)
            {
                return "declined payout '" + payoutResult.Id + "' with status '" + payoutResult.Status + "'";
            }
            return "the Worldline Global Collect platform returned a declined payout response";
        }
    }
}
