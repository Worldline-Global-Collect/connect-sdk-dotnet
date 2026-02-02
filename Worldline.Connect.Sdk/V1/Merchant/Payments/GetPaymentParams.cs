/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.Communication;

namespace Worldline.Connect.Sdk.V1.Merchant.Payments
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/payments/get.html">Get payment</a>
    /// </summary>
    public class GetPaymentParams : AbstractParamRequest
    {
        /// <summary>
        /// This property only works for the multiple partial captures payments. If set to true, in the response of this call you will get an array called operations, that will include objects for captures and refunds associated with the given paymentId.
        /// </summary>
        public bool? ReturnOperations { get; set; }

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            var result = new List<RequestParam>();
            if (ReturnOperations != null)
            {
                result.Add(new RequestParam("returnOperations", ReturnOperations.ToString().ToLower()));
            }
            return result;
        }
    }
}
