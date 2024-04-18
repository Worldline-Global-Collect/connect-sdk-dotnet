/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.Communication;

namespace Worldline.Connect.Sdk.V1.Merchant.Payouts
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/payouts/find.html">Find payouts</a>
    /// </summary>
    public class FindPayoutsParams : AbstractParamRequest
    {
        /// <summary>
        /// Your unique transaction reference to filter on.
        /// </summary>
        public string MerchantReference { get; set; }

        /// <summary>
        /// Your order identifier to filter on.
        /// </summary>
        public long? MerchantOrderId { get; set; }

        /// <summary>
        /// The zero-based index of the first payout in the result. If omitted, the offset will be 0.
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// The maximum number of payouts to return, with a maximum of 100. If omitted, the limit will be 10.
        /// </summary>
        public int? Limit { get; set; }

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            var result = new List<RequestParam>();
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
