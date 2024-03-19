/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.Communication;

namespace Worldline.Connect.Sdk.V1.Merchant.Services
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/services/convertAmount.html">Convert amount</a>
    /// </summary>
    public class ConvertAmountParams : AbstractParamRequest
    {
        /// <summary>
        /// Three-letter ISO currency code representing the source currency
        /// </summary>
        public string Source { get; set; } = null;

        /// <summary>
        /// Three-letter ISO currency code representing the target currency
        /// </summary>
        public string Target { get; set; } = null;

        /// <summary>
        /// Amount to be converted in cents and always having 2 decimals
        /// </summary>
        public long? Amount { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            var result = new List<RequestParam>();
            if (Source != null)
            {
                result.Add(new RequestParam("source", Source));
            }
            if (Target != null)
            {
                result.Add(new RequestParam("target", Target));
            }
            if (Amount != null)
            {
                result.Add(new RequestParam("amount", Amount.ToString()));
            }
            return result;
        }
    }
}
