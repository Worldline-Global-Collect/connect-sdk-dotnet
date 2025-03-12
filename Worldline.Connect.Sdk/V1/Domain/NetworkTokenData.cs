/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class NetworkTokenData
    {
        /// <summary>
        /// The network token alternative for the full Permanent Account Number. To receive a non-obfuscated network token please contact your account manager.
        /// </summary>
        public string NetworkToken { get; set; }

        /// <summary>
        /// The expiry date of the network token.
        /// </summary>
        public string TokenExpiryDate { get; set; }

        /// <summary>
        /// A unique identifier that can be used with Visa Token Service (VTS) or Mastercard Digital Enablement Service (MDES) to retrieve token details. It remains valid as long as the token is valid. Note: A prefix "V:" is added to show that this is a network token for a Visa product and "M:" to show that this is a network token for a Mastercard product.
        /// </summary>
        public string TokenReferenceId { get; set; }
    }
}
