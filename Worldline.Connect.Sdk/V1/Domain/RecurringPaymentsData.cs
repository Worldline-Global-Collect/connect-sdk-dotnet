/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RecurringPaymentsData
    {
        /// <summary>
        /// The object containing information specific to Apple Pay
        /// </summary>
        public PaymentProduct302SpecificInput PaymentProduct302SpecificInput { get; set; }

        /// <summary>
        /// The date that the recurring payment ends in YYYYMMDD format.
        /// </summary>
        public string RecurringEndDate { get; set; }

        /// <summary>
        /// The object containing the frequency and interval between recurring payments.
        /// </summary>
        public Frequency RecurringInterval { get; set; }

        /// <summary>
        /// The date that the first recurring payment starts in YYYYMMDD format.
        /// </summary>
        public string RecurringStartDate { get; set; }

        /// <summary>
        /// The object containing data of the trial period: no-cost or discounted time-constrained trial subscription period.
        /// </summary>
        public TrialInformation TrialInformation { get; set; }
    }
}
