/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class DeviceFingerprintDetails
    {
        /// <summary>
        /// The ID of the payment that is linked to the Device Fingerprint data.
        /// </summary>
        public string PaymentId { get; set; }

        /// <summary>
        /// The detailed data that was collected during the Device Fingerprint collection. The structure will be different depending on the collection method and device fingerprint partner used. Please contact us if you want more information on the details that are returned in this string.
        /// </summary>
        public string RawDeviceFingerprintOutput { get; set; }
    }
}
