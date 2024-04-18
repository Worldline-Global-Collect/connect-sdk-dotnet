/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Net;
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
        public RefundResult RefundResult => _response?.RefundResult;

        public DeclinedRefundException(HttpStatusCode statusCode, string responseBody, RefundErrorResponse response)
            : base(BuildMessage(response), statusCode, responseBody, response?.ErrorId, response?.Errors)
        {
            _response = response;
        }

        private readonly RefundErrorResponse _response;

        private static string BuildMessage(RefundErrorResponse response)
        {
            var refundResult = response?.RefundResult;
            if (refundResult != null)
            {
                return "declined refund '" + refundResult.Id + "' with status '" + refundResult.Status + "'";
            }
            return "the Worldline Global Collect platform returned a declined refund response";
        }
    }
}
