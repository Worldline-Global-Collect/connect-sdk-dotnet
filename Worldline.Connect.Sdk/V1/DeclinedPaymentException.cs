/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1
{
    /// <summary>
    /// Represents an error response from a create payment call.
    /// </summary>
    public class DeclinedPaymentException : DeclinedTransactionException
    {
        /// <summary>
        /// Gets the result of creating a payment if available, otherwise <c>null</c>.
        /// </summary>
        public CreatePaymentResult CreatePaymentResult => _errors?.PaymentResult;

        public DeclinedPaymentException(System.Net.HttpStatusCode statusCode, string responseBody, PaymentErrorResponse errors)
            : base(BuildMessage(errors), statusCode, responseBody, errors?.ErrorId, errors?.Errors)
        {
            _errors = errors;
        }

        private readonly PaymentErrorResponse _errors;

        private static string BuildMessage(PaymentErrorResponse errors)
        {
            var payment = errors?.PaymentResult?.Payment;
            if (payment != null)
            {
                return "declined payment '" + payment.Id + "' with status '" + payment.Status + "'";
            }
            return "the Worldline Global Collect platform returned a declined payment response";
        }
    }
}
