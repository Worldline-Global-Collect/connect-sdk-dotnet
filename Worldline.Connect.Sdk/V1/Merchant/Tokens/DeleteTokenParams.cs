/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.Communication;

namespace Worldline.Connect.Sdk.V1.Merchant.Tokens
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/tokens/delete.html">Delete token</a>
    /// </summary>
    public class DeleteTokenParams : AbstractParamRequest
    {
        /// <summary>
        /// Date of the mandate cancellation
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string MandateCancelDate { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            var result = new List<RequestParam>();
            if (MandateCancelDate != null)
            {
                result.Add(new RequestParam("mandateCancelDate", MandateCancelDate));
            }
            return result;
        }
    }
}
