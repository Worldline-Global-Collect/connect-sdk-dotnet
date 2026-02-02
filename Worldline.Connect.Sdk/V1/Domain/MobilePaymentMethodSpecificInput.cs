/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MobilePaymentMethodSpecificInput : AbstractMobilePaymentMethodSpecificInput
    {
        /// <summary>
        /// The payment data if you do the decryption of the encrypted payment data yourself.
        /// </summary>
        public DecryptedPaymentData DecryptedPaymentData { get; set; }

        /// <summary>
        /// The payment data if we will do the decryption of the encrypted payment data.
        /// <br />
        /// <p>Typically you'd use encryptedCustomerInput in the root of the create payment request to provide the encrypted payment data instead.</p>
        /// <list type="bullet">
        ///   <item><description>For Apple Pay, the encrypted payment data is the 
        ///   <nobr>
        ///   <a href="https://developer.apple.com/documentation/passkit/pkpayment" target="_blank">PKPayment</a>.token.paymentData</nobr> object passed as a string (with all quotation marks escaped).</description></item>
        ///   <item><description>For Google Pay, the encrypted payment data can be found in property paymentMethodData.tokenizationData.token of the 
        ///   <nobr>
        ///   <a href="https://developers.google.com/android/reference/com/google/android/gms/wallet/PaymentData" target="_blank">PaymentData</a>.toJson()</nobr> result.</description></item>
        /// </list>
        /// </summary>
        public string EncryptedPaymentData { get; set; }

        /// <summary>
        /// Indicates if this transaction is of a one-off or a recurring type 
        /// <list type="bullet">
        ///   <item><description>true - This is recurring</description></item>
        ///   <item><description>false - This is one-off</description></item>
        /// </list>
        /// </summary>
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// Indicates reason behind the merchant initiated transaction. These are industry specific.
        /// <br />Possible values: 
        /// <list type="bullet">
        ///   <item><description>delayedCharges - Delayed charges are performed to process a supplemental account charge after original services have been rendered and respective payment has been processed. This is typically used in hotel, cruise lines and vehicle rental environments to perform a supplemental payment after the original services are rendered.</description></item>
        ///   <item><description>noShow - Cardholders can use their cards to make a guaranteed reservation with certain merchant segments. A guaranteed reservation ensures that the reservation will be honored and allows a merchant to perform a No Show transaction to charge the cardholder a penalty according to the merchant&#8217;s cancellation policy. For merchants that accept token-based payment credentials to guarantee a reservation, it is necessary to perform a customer initiated (Account Verification) at the time of reservation to be able perform a No Show transaction later.</description></item>
        /// </list>
        /// </summary>
        public string MerchantInitiatedReasonIndicator { get; set; }

        /// <summary>
        /// Object containing information specific to Google Pay
        /// </summary>
        public MobilePaymentProduct320SpecificInput PaymentProduct320SpecificInput { get; set; }
    }
}
