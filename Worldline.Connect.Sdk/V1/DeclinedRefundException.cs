/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1
{
    /// <summary>
    /// Represents an error response from a refund call.
    /// </summary>
    public class DeclinedRefundException : DeclinedTransactionException
    {
        /// <summary>
        /// Gets the result of creating a refund if available, otherwise <c>null</c>.
        /// </summary>
        public RefundResult RefundResult => _errors?.RefundResult;

        public DeclinedRefundException(System.Net.HttpStatusCode statusCode, string responseBody, RefundErrorResponse errors)
            : base(BuildMessage(errors), statusCode, responseBody, errors?.ErrorId, errors?.Errors)
        {
            _errors = errors;
        }

        private readonly RefundErrorResponse _errors;

        private static string BuildMessage(RefundErrorResponse errors)
        {
            var refund = errors?.RefundResult;
            if (refund != null)
            {
                return "declined refund '" + refund.Id + "' with status '" + refund.Status + "'";
            }
            return "the Worldline Global Collect platform returned a declined refund response";
        }
    }
}
