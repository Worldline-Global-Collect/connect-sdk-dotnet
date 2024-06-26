/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CreateHostedCheckoutResponse
    {
        /// <summary>
        /// When the customer is returned to your site we will append this property and value to the query-string. You should store this data, so you can identify the returning customer.
        /// </summary>
        [JsonProperty(PropertyName = "RETURNMAC")]
        public string RETURNMAC { get; set; }

        /// <summary>
        /// This is the ID under which the data for this checkout can be retrieved.
        /// </summary>
        public string HostedCheckoutId { get; set; }

        /// <summary>
        /// Tokens that are submitted in the request are validated. In case any of the tokens can't be used anymore they are returned in this array. You should most likely remove those tokens from your system.
        /// </summary>
        public IList<string> InvalidTokens { get; set; }

        /// <summary>
        /// If a payment is created during this hosted checkout, then it will use this merchantReference. This is the merchantReference you provided in the Create Hosted Checkout request, or if you did not provide one, a reference generated by Connect. This allows you to to link a webhook related to the created payment back to this hosted checkout using the webhook's paymentOutput.references.merchantReference.
        /// <br />
        /// <br />This property is intended primarily for hosted checkouts on the Ogone Payment Platform. On the GlobalCollect platform, you can also use hostedCheckoutSpecificOutput.hostedCheckoutId.
        /// </summary>
        public string MerchantReference { get; set; }

        /// <summary>
        /// The partial URL as generated by our system. You will need to add the protocol and the relevant subdomain to this URL, before redirecting your customer to this URL. A special 'payment' subdomain will always work so you can always add 'https://payment.' at the beginning of this response value to view your MyCheckout hosted payment pages.
        /// </summary>
        public string PartialRedirectUrl { get; set; }
    }
}
