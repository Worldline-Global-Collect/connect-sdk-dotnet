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
    /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/services/privacypolicy.html">Get privacy policy</a>
    /// </summary>
    public class PrivacypolicyParams : AbstractParamRequest
    {
        /// <summary>
        /// Locale in which the privacy policy should be returned. Uses your default locale when none is provided.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// ID of the payment product for which you wish to retrieve the privacy policy. When no ID is provided you will receive all privacy policies for your payment products.
        /// </summary>
        public int? PaymentProductId { get; set; }

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            var result = new List<RequestParam>();
            if (Locale != null)
            {
                result.Add(new RequestParam("locale", Locale));
            }
            if (PaymentProductId != null)
            {
                result.Add(new RequestParam("paymentProductId", PaymentProductId.ToString()));
            }
            return result;
        }
    }
}
