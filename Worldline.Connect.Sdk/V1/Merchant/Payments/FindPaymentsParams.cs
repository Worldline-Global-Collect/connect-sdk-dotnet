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
    /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/payments/find.html">Find payments</a>
    /// </summary>
    public class FindPaymentsParams : AbstractParamRequest
    {
        /// <summary>
        /// Your hosted checkout identifier to filter on.
        /// </summary>
        public string HostedCheckoutId { get; set; }

        /// <summary>
        /// Your unique transaction reference to filter on. The maximum length is 52 characters for payments that are processed by WL Online Payment Acceptance platform.
        /// </summary>
        public string MerchantReference { get; set; }

        /// <summary>
        /// Your order identifier to filter on.
        /// </summary>
        public long? MerchantOrderId { get; set; }

        /// <summary>
        /// The zero-based index of the first payment in the result. If omitted, the offset will be 0.
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// The maximum number of payments to return, with a maximum of 100. If omitted, the limit will be 10.
        /// </summary>
        public int? Limit { get; set; }

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            var result = new List<RequestParam>();
            if (HostedCheckoutId != null)
            {
                result.Add(new RequestParam("hostedCheckoutId", HostedCheckoutId));
            }
            if (MerchantReference != null)
            {
                result.Add(new RequestParam("merchantReference", MerchantReference));
            }
            if (MerchantOrderId != null)
            {
                result.Add(new RequestParam("merchantOrderId", MerchantOrderId.ToString()));
            }
            if (Offset != null)
            {
                result.Add(new RequestParam("offset", Offset.ToString()));
            }
            if (Limit != null)
            {
                result.Add(new RequestParam("limit", Limit.ToString()));
            }
            return result;
        }
    }
}
