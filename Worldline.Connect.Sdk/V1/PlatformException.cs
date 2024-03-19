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
    /// Represents an error response from the Worldline Global Collect platform when something went wrong at the Worldline Global Collect platform or further downstream.
    /// </summary>
    public class PlatformException : ApiException
    {
        public PlatformException(HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base("the Worldline Global Collect platform returned an error response", statusCode, responseBody, errorId, errors)
        {

        }

        public PlatformException(string message, HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base(message, statusCode, responseBody, errorId, errors)
        {

        }
    }
}
