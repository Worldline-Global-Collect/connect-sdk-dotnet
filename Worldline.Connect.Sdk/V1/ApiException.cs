/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1
{
    /// <summary>
    /// Represents an error response from the Worldline Global Collect platform which contains an ID and a list of errors.
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Gets the HTTP status code that was returned by the Worldline Global Collect platform.
        /// </summary>
        public System.Net.HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gets the raw response body that was returned by the Worldline Global Collect platform.
        /// </summary>
        public string ResponseBody { get; }

        /// <summary>
        /// Gets the error identifier received from the Worldline Global Collect platform if available.
        /// </summary>
        public string ErrorId { get; }

        /// <summary>
        /// Gets the error list received from the Worldline Global Collect platform if available. Never <c>null</c>.
        /// </summary>
        public IList<APIError> Errors { get; }

        public ApiException(System.Net.HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : this("the Worldline Global Collect platform returned an error response", statusCode, responseBody, errorId, errors)
        {

        }

        public ApiException(string message, System.Net.HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base(message)
        {
            StatusCode = statusCode;
            ResponseBody = responseBody;
            ErrorId = errorId;
            Errors = errors ?? new List<APIError>();
        }

        public override string ToString()
        {
            var list = new StringBuilder(base.ToString());
            if (StatusCode > 0)
            {
                list.Append("; statusCode=").Append(StatusCode.ToString());
            }
            if (ResponseBody != null && ResponseBody.Any())
            {
                list.Append("; responseBody='").Append(ResponseBody).Append("'");
            }
            return list.ToString();
        }
    }
}
