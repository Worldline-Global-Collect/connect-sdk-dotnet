/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class IINDetail
    {
        /// <summary>
        /// Populated only if you submitted a payment context. 
        /// <list type="bullet">
        ///   <item><description>true - The payment product is allowed in the submitted context.</description></item>
        ///   <item><description>false - The payment product is not allowed in the submitted context. Note that in this case, none of the brands of the card will be allowed in the submitted context.</description></item>
        /// </list>
        /// </summary>
        public bool? IsAllowedInContext { get; set; }

        /// <summary>
        /// Payment product identifier
        /// <br />Please see 
        /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/paymentproducts.html">payment products</a> for a full overview of possible values.
        /// </summary>
        public int? PaymentProductId { get; set; }
    }
}
