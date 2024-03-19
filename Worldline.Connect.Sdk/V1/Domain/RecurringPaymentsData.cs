/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RecurringPaymentsData
    {
        /// <summary>
        /// The object containing the frequency and interval between recurring payments.
        /// </summary>
        public Frequency RecurringInterval { get; set; } = null;

        /// <summary>
        /// The object containing data of the trial period: no-cost or discounted time-constrained trial subscription period.
        /// </summary>
        public TrialInformation TrialInformation { get; set; } = null;
    }
}
