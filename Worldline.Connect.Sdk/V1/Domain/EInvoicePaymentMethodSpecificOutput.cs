/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class EInvoicePaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Object containing the results of the fraud screening
        /// </summary>
        public FraudResults FraudResults { get; set; }

        /// <summary>
        /// AfterPay Installments (payment product 9000) specific details
        /// </summary>
        public EInvoicePaymentProduct9000SpecificOutput PaymentProduct9000SpecificOutput { get; set; }
    }
}
