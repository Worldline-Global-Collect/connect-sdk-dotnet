/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RedirectPaymentMethodSpecificInput : AbstractRedirectPaymentMethodSpecificInput
    {
        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// Object containing specific input required for UPI (Payment product ID 4101)
        /// </summary>
        public RedirectPaymentProduct4101SpecificInput PaymentProduct4101SpecificInput { get; set; }

        /// <summary>
        /// Object containing specific input required for Dutch iDeal payments (Payment product ID 809)
        /// </summary>
        public RedirectPaymentProduct809SpecificInput PaymentProduct809SpecificInput { get; set; }

        /// <summary>
        /// Object containing specific input required for PayPal payments (Payment product ID 840)
        /// </summary>
        public RedirectPaymentProduct840SpecificInput PaymentProduct840SpecificInput { get; set; }

        /// <summary>
        /// Object containing specific input required for AliPay payments (Payment product ID 861)
        /// </summary>
        public RedirectPaymentProduct861SpecificInput PaymentProduct861SpecificInput { get; set; }

        /// <summary>
        /// Object containing specific input required for We Chat Pay payments (Payment product ID 863)
        /// </summary>
        public RedirectPaymentProduct863SpecificInput PaymentProduct863SpecificInput { get; set; }

        /// <summary>
        /// Object containing specific input required for China UnionPay payments (Payment product ID 869)
        /// </summary>
        public RedirectPaymentProduct869SpecificInput PaymentProduct869SpecificInput { get; set; }

        /// <summary>
        /// Object containing specific input required for Indian Net Banking payments (Payment product ID 882)
        /// </summary>
        public RedirectPaymentProduct882SpecificInput PaymentProduct882SpecificInput { get; set; }

        /// <summary>
        /// Object containing browser specific redirection related data
        /// </summary>
        public RedirectionData RedirectionData { get; set; }

        /// <summary>
        /// The URL that the customer is redirect to after the payment flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the customer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process.
        /// <br />Note: The provided URL should be absolute and contain the https:// protocol. IP addresses are not supported, neither localhost. For use on mobile devices a custom protocol can be used in the form of 
        /// <i>protocol</i>://. This protocol must be registered on the device first.
        /// <br />URLs without a protocol will be rejected.
        /// </summary>
        [Obsolete("Use redirectionData.returnUrl instead")]
        public string ReturnUrl { get; set; }
    }
}
