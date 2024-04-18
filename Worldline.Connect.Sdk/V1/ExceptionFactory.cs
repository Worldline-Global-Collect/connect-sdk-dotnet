/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1
{
    /// <summary>
    /// Factory for exceptions thrown by Worldline Global Collect platform API v1 resources.
    /// </summary>
    public static class ExceptionFactory
    {
        public static Exception CreateException(HttpStatusCode statusCode, string responseBody, object errorObject, CallContext context)
        {
            if (errorObject is PaymentErrorResponse paymentErrorResponse)
            {
                return paymentErrorResponse.PaymentResult != null ? new DeclinedPaymentException(statusCode, responseBody, paymentErrorResponse) : CreateException(statusCode, responseBody, paymentErrorResponse.ErrorId, paymentErrorResponse.Errors, context);
            }
            if (errorObject is PayoutErrorResponse payoutErrorResponse)
            {
                return payoutErrorResponse.PayoutResult != null ? new DeclinedPayoutException(statusCode, responseBody, payoutErrorResponse) : CreateException(statusCode, responseBody, payoutErrorResponse.ErrorId, payoutErrorResponse.Errors, context);
            }
            if (errorObject is RefundErrorResponse refundErrorResponse)
            {
                return refundErrorResponse.RefundResult != null ? new DeclinedRefundException(statusCode, responseBody, refundErrorResponse) : CreateException(statusCode, responseBody, refundErrorResponse.ErrorId, refundErrorResponse.Errors, context);
            }
            if (errorObject is ErrorResponse errorResponse)
            {
                return CreateException(statusCode, responseBody, errorResponse.ErrorId, errorResponse.Errors, context);
            }
            if (errorObject == null)
            {
                return CreateException(statusCode, responseBody, null, null, context);
            }
            throw new ArgumentException("unsupported error object type: " + errorObject.GetType());
        }

        private static Exception CreateException(HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors, CallContext context)
        {
            switch (statusCode)
            {
                case HttpStatusCode.BadRequest:
                    return new ValidationException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.Forbidden:
                    return new AuthorizationException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.NotFound:
                    return new ReferenceException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.Conflict:
                    if (IsIdempotenceError(errors, context))
                    {
                        var idempotenceKey = context.IdempotenceKey;
                        var idempotenceRequestTimestamp = context.IdempotenceRequestTimestamp;
                        return new IdempotenceException(idempotenceKey, idempotenceRequestTimestamp, statusCode, responseBody, errorId, errors);
                    }
                    return new ReferenceException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.Gone:
                    return new ReferenceException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.InternalServerError:
                    return new PlatformException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.BadGateway:
                    return new PlatformException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.ServiceUnavailable:
                    return new PlatformException(statusCode, responseBody, errorId, errors);
                default:
                    return new ApiException(statusCode, responseBody, errorId, errors);
            }
        }

        private static bool IsIdempotenceError(IList<APIError> errors, CallContext context)
        {
            return context?.IdempotenceKey != null
                   && errors?.Count == 1
                   && "1409".Equals(errors.ElementAt(0)?.Code);
        }
    }
}
