/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class GetIINDetailsResponse
    {
        /// <summary>
        /// Indicates the type or segments of consumer's BIN is issued. It helps to offer targeted benefits to the consumers, and helps to request exemption for additional authentications. The possible values are: 
        /// <list type="bullet">
        ///   <item><description>CONSUMER</description></item>
        ///   <item><description>COMMERCIAL</description></item>
        ///   <item><description>VIRTUAL</description></item>
        ///   <item><description>ALL</description></item>
        ///   <item><description>OTHER</description></item>
        /// </list>
        /// </summary>
        public string BinProductType { get; set; }

        /// <summary>
        /// Populated only if the card has multiple brands. A list with for every brand of the card, the payment product identifier associated with that brand, and if you submitted a payment context, whether that payment product is allowed in the context.
        /// </summary>
        public IList<IINDetail> CoBrands { get; set; }

        /// <summary>
        /// The ISO 3166-1 alpha-2 country code of the country where the card was issued. If we don't know where the card was issued, then the countryCode will return the value '99'.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Populated only if you submitted a payment context. 
        /// <list type="bullet">
        ///   <item><description>true - The payment product is allowed in the submitted context.</description></item>
        ///   <item><description>false - The payment product is not allowed in the submitted context. Note that in this case, none of the brands of the card will be allowed in the submitted context.</description></item>
        /// </list>
        /// </summary>
        public bool? IsAllowedInContext { get; set; }

        /// <summary>
        /// The name of the card issuer associated with the card.
        /// </summary>
        public string IssuerName { get; set; }

        /// <summary>
        /// The payment product identifier associated with the card. If the card has multiple brands, then we select the most appropriate payment product based on your configuration and the payment context, if you submitted one.
        /// <br />Please see 
        /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/paymentproducts.html">payment products</a> for a full overview of possible values
        /// </summary>
        public int? PaymentProductId { get; set; }
    }
}
