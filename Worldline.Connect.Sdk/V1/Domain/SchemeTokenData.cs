/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class SchemeTokenData
    {
        /// <summary>
        /// The card holder's name on the card. Minimum length of 2, maximum length of 51 characters.
        /// </summary>
        public string CardholderName { get; set; }

        /// <summary>
        /// The Token Cryptogram is a dynamic one-time use value that is used to verify the authenticity of the transaction and the integrity of the data used in the generation of the Token Cryptogram. Visa calls this the Token Authentication Verification Value (TAVV) cryptogram.
        /// </summary>
        public string Cryptogram { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator you got with the Token Cryptogram
        /// </summary>
        public string Eci { get; set; }

        /// <summary>
        /// The network token. Note: This is called Payment Token in the EMVCo documentation
        /// </summary>
        public string NetworkToken { get; set; }

        /// <summary>
        /// The expiry date of the network token
        /// </summary>
        public string TokenExpiryDate { get; set; }
    }
}
