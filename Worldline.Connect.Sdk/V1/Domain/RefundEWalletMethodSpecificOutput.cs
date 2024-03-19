/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RefundEWalletMethodSpecificOutput : RefundMethodSpecificOutput
    {
        /// <summary>
        /// PayPal (payment product 840) specific details
        /// </summary>
        public RefundPaymentProduct840SpecificOutput PaymentProduct840SpecificOutput { get; set; } = null;
    }
}
