/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MobilePaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Card Authorization code as returned by the acquirer
        /// </summary>
        public string AuthorisationCode { get; set; } = null;

        /// <summary>
        /// Fraud results contained in the CardFraudResults object
        /// </summary>
        public CardFraudResults FraudResults { get; set; } = null;

        /// <summary>
        /// The network that was used for the refund
        /// </summary>
        public string Network { get; set; } = null;

        /// <summary>
        /// Object containing payment details
        /// </summary>
        public MobilePaymentData PaymentData { get; set; } = null;

        /// <summary>
        /// 3D Secure results object
        /// </summary>
        public ThreeDSecureResults ThreeDSecureResults { get; set; } = null;
    }
}
