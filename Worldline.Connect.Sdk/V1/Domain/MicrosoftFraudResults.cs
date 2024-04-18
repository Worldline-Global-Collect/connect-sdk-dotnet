/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MicrosoftFraudResults
    {
        /// <summary>
        /// Name of the clause within the applied policy that was triggered during the evaluation of this transaction.
        /// </summary>
        public string ClauseName { get; set; }

        /// <summary>
        /// The country of the customer determined by Microsoft Device Fingerprinting.
        /// </summary>
        public string DeviceCountryCode { get; set; }

        /// <summary>
        /// This is the device fingerprint value. Based on the amount of data that the device fingerprint collector script was able to collect, this will be a proxy ID for the device used by the customer.
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Result of the Microsoft Fraud Protection check. This contains the normalized fraud score from a scale of 0 to 100. A higher score indicates an increased risk of fraud.
        /// </summary>
        public int? FraudScore { get; set; }

        /// <summary>
        /// Name of the policy that was applied on during the evaluation of this transaction.
        /// </summary>
        public string PolicyApplied { get; set; }

        /// <summary>
        /// The true IP address as determined by Microsoft Device Fingerprinting.
        /// </summary>
        public string TrueIpAddress { get; set; }

        /// <summary>
        /// The type of device used by the customer.
        /// </summary>
        public string UserDeviceType { get; set; }
    }
}
