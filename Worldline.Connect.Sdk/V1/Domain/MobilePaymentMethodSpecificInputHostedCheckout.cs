/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MobilePaymentMethodSpecificInputHostedCheckout : AbstractMobilePaymentMethodSpecificInput
    {
        /// <summary>
        /// Object containing information specific to Apple Pay
        /// </summary>
        public MobilePaymentProduct302SpecificInputHostedCheckout PaymentProduct302SpecificInput { get; set; }

        /// <summary>
        /// Object containing information specific to Google Pay (paymentProductId 320)
        /// </summary>
        public MobilePaymentProduct320SpecificInputHostedCheckout PaymentProduct320SpecificInput { get; set; }
    }
}
