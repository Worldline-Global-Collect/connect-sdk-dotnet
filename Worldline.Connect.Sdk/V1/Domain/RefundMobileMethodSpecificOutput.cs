/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RefundMobileMethodSpecificOutput : RefundMethodSpecificOutput
    {
        /// <summary>
        /// The network that was used for the refund. The string that represents the network is identical to the strings that the payment product vendors use in their documentation. For instance: "Visa" for 
        /// <a href="https://developer.apple.com/reference/passkit/pkpaymentnetwork" target="_blank">Apple Pay</a>, and "VISA" for 
        /// <a href="https://developers.google.com/pay/api/android/reference/object#CardParameters" target="_blank">Google Pay</a>.
        /// </summary>
        public string Network { get; set; }
    }
}
