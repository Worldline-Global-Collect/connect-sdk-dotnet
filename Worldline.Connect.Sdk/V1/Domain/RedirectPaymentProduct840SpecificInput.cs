/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RedirectPaymentProduct840SpecificInput : AbstractRedirectPaymentProduct840SpecificInput
    {
        /// <summary>
        /// A free text string that you can send to PayPal. With a special agreement between PayPal and you, PayPal uses the data in that property, for custom services they offer to you.
        /// </summary>
        [Obsolete("Use Order.references.descriptor instead")]
        public string Custom { get; set; }

        /// <summary>
        /// <div class="deprecated-wrapper depends-wrapper">Deprecated: If your PayPal payments are processed by Worldline's Ogone Payment Platform, please use the property addressSelectionAtPayPal instead.</div>
        /// <br />Indicates whether to use PayPal Express Checkout for payments processed by Worldline's GlobalCollect Payment Platform. 
        /// <list type="bullet">
        ///   <item><description>true = PayPal Express Checkout</description></item>
        ///   <item><description>false = Regular PayPal payment</description></item>
        /// </list>For payments processed by Worldline's Ogone Payment Platform, please see the addressSelectionAtPayPal property for more information.
        /// </summary>
        public bool? IsShortcut { get; set; }
    }
}
