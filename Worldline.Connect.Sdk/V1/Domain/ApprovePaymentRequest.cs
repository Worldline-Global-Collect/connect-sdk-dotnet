/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ApprovePaymentRequest
    {
        /// <summary>
        /// In case you want to approve the capture of a different lower amount you can specify this here (specified in cents, where single digit currencies are presumed to have 2 digits)
        /// </summary>
        public long? Amount { get; set; }

        /// <summary>
        /// Object that holds non-SEPA Direct Debit specific input data
        /// </summary>
        public ApprovePaymentNonSepaDirectDebitPaymentMethodSpecificInput DirectDebitPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object that holds the order data
        /// </summary>
        public OrderApprovePayment Order { get; set; }

        /// <summary>
        /// Object that holds SEPA Direct Debit specific input data
        /// </summary>
        public ApprovePaymentSepaDirectDebitPaymentMethodSpecificInput SepaDirectDebitPaymentMethodSpecificInput { get; set; }
    }
}
