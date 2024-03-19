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
    /// Represents an error response from the Worldline Global Collect platform when a non-existing or removed object is trying to be accessed.
    /// </summary>
    public class ReferenceException : ApiException
    {
        public ReferenceException(HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base("the Worldline Global Collect platform returned an incorrect request error response", statusCode, responseBody, errorId, errors)
        {

        }

        public ReferenceException(string message, HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base(message, statusCode, responseBody, errorId, errors)
        {

        }
    }
}
