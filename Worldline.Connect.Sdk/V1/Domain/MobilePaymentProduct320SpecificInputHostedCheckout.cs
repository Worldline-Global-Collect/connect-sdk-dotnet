/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MobilePaymentProduct320SpecificInputHostedCheckout
    {
        /// <summary>
        /// Used as an input for the Google Pay payment sheet. Provide your company name in a human readable form.
        /// </summary>
        public string MerchantName { get; set; }

        /// <summary>
        /// Used as an input for the Google Pay payment sheet. Provide the url of your webshop. For international (non-ASCII) domains, please use 
        /// <a href="https://en.wikipedia.org/wiki/Punycode">Punycode</a>.
        /// </summary>
        public string MerchantOrigin { get; set; }

        /// <summary>
        /// Object containing specific data regarding 3-D Secure
        /// </summary>
        public GPayThreeDSecure ThreeDSecure { get; set; }
    }
}
