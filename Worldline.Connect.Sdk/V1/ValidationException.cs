/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using System.Net;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1
{
    /// <summary>
    /// Represents an error response from the Worldline Global Collect platform when validation of requests failed.
    /// </summary>
    public class ValidationException : ApiException
    {

        public ValidationException(HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base("the Worldline Global Collect platform returned an incorrect request error response", statusCode, responseBody, errorId, errors)
        {

        }

        public ValidationException(string message, HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base(message, statusCode, responseBody, errorId, errors)
        {

        }
    }
}
