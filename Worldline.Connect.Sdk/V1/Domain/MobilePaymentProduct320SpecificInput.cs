/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MobilePaymentProduct320SpecificInput
    {
        /// <summary>
        /// The card holder's name on the card. Minimum length of 2, maximum length of 51 characters.
        /// <br />The encrypted payment data can be found in property paymentMethodData.tokenizationData.info.billingAddress.name of the 
        /// <a href="https://developers.google.com/android/reference/com/google/android/gms/wallet/PaymentData">PaymentData</a>.toJson() result.
        /// </summary>
        public string CardholderName { get; set; }

        /// <summary>
        /// Object containing specific data regarding 3-D Secure
        /// </summary>
        public GPayThreeDSecure ThreeDSecure { get; set; }
    }
}
