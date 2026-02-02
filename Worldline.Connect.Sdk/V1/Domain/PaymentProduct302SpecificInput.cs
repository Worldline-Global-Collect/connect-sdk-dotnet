/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProduct302SpecificInput
    {
        /// <summary>
        /// An object that contains the reload amount and balance threshold for the automatic reload payment.
        /// </summary>
        public AutomaticReloadBillingDetails AutomaticReloadBilling { get; set; }

        /// <summary>
        /// A localized description shown to inform the user about the billing terms before authorization. It can include details or conditions of payment, and may describe how customer can cancel payments.
        /// </summary>
        public string BillingAgreement { get; set; }

        /// <summary>
        /// An object that contains details about the deferred payment.
        /// </summary>
        public DeferredBillingDetails DeferredBilling { get; set; }

        /// <summary>
        /// A URL to a web page where the customer can update or delete the payment method for the recurring, deferred or automatic reload payment made with Apple Pay.
        /// </summary>
        public string ManagementUrl { get; set; }

        /// <summary>
        /// The description of the payment used to identify the transaction purpose.
        /// </summary>
        public string PaymentDescription { get; set; }

        /// <summary>
        /// An object that contains the regular billing cycle for the recurring payment, including start and end dates, an interval, and an interval count.
        /// </summary>
        public RecurringBillingDetails RegularBilling { get; set; }

        /// <summary>
        /// A URL you provide to receive life-cycle notifications from the Apple Pay servers about the Apple Pay merchant token for the recurring payment.
        /// </summary>
        public string TokenNotificationUrl { get; set; }

        /// <summary>
        /// An object that contains the trial billing cycle for the recurring payment.
        /// </summary>
        public RecurringBillingDetails TrialBilling { get; set; }
    }
}
