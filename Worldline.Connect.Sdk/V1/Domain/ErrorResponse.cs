/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ErrorResponse
    {
        /// <summary>
        /// Unique reference, for debugging purposes, of this error response
        /// </summary>
        public string ErrorId { get; set; }

        /// <summary>
        /// List of one or more errors
        /// </summary>
        public IList<APIError> Errors { get; set; }
    }
}
