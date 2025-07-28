/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RedirectPaymentMethodSpecificInputBase : AbstractRedirectPaymentMethodSpecificInput
    {
        /// <summary>
        /// Object containing specific input required for payment product 4101 (UPI)
        /// </summary>
        public RedirectPaymentProduct4101SpecificInputBase PaymentProduct4101SpecificInput { get; set; }

        /// <summary>
        /// Object containing specific input required for Klarna payments (Payment product ID 838)
        /// </summary>
        public RedirectPaymentProduct838SpecificInputBase PaymentProduct838SpecificInput { get; set; }

        /// <summary>
        /// Object containing specific input required for PayPal payments (Payment product ID 840)
        /// </summary>
        public RedirectPaymentProduct840SpecificInputBase PaymentProduct840SpecificInput { get; set; }
    }
}
