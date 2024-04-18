/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CancelPaymentResponse
    {
        /// <summary>
        /// Object that holds specific information on cancelled card payments
        /// </summary>
        public CancelPaymentCardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object that holds specific information on cancelled mobile payments
        /// </summary>
        public CancelPaymentMobilePaymentMethodSpecificOutput MobilePaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object that holds the payment related properties
        /// </summary>
        public Payment Payment { get; set; }
    }
}
