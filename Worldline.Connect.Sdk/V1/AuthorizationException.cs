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
    /// Represents an error response from the Worldline Global Collect platform when authorization failed.
    /// </summary>
    public class AuthorizationException : ApiException
    {
        public AuthorizationException(HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base("The Worldline Global Collect platform returned an incorrect request error response", statusCode, responseBody, errorId, errors)
        {

        }

        public AuthorizationException(string message, HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors) : base(message, statusCode, responseBody, errorId, errors)
        {

        }
    }
}
