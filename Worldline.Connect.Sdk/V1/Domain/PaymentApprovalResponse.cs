/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentApprovalResponse
    {
        /// <summary>
        /// Object containing additional card payment method specific details
        /// </summary>
        public ApprovePaymentCardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object containing additional mobile payment method specific details
        /// </summary>
        public ApprovePaymentMobilePaymentMethodSpecificOutput MobilePaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object that holds the payment data
        /// </summary>
        public Payment Payment { get; set; }

        /// <summary>
        /// Object containing additional payment method specific details
        /// <br />Deprecated: this property does not support different outputs for payment methods other than cards. Please use cardPaymentMethodSpecificOutput instead.
        /// </summary>
        [Obsolete("Use cardPaymentMethodSpecificOutput instead")]
        public ApprovePaymentCardPaymentMethodSpecificOutput PaymentMethodSpecificOutput { get; set; }
    }
}
