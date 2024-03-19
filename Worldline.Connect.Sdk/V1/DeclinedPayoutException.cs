/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1
{
    /// <summary>
    /// Represents an error response from a create payout call.
    /// </summary>
    public class DeclinedPayoutException : DeclinedTransactionException
    {
        /// <summary>
        /// Gets the result of creating a payout if available, otherwise <c>null</c>.
        /// </summary>
        public PayoutResult PayoutResult => _errors?.PayoutResult;

        public DeclinedPayoutException(System.Net.HttpStatusCode statusCode, string responseBody, PayoutErrorResponse errors)
            : base(BuildMessage(errors), statusCode, responseBody, errors?.ErrorId, errors?.Errors)
        {
            _errors = errors;
        }

        private readonly PayoutErrorResponse _errors;

        private static string BuildMessage(PayoutErrorResponse errors)
        {
            var payout = errors?.PayoutResult;
            if (payout != null)
            {
                return "declined payout '" + payout.Id + "' with status '" + payout.Status + "'";
            }
            return "the Worldline Global Collect platform returned a declined payout response";
        }
    }
}
