/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class InvoicePaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        /// <summary>
        /// Your (additional) reference identifier for this transaction. Data supplied in this property will also be returned in our report files, allowing you to reconcile the incoming funds.
        /// </summary>
        public string AdditionalReference { get; set; }
    }
}
