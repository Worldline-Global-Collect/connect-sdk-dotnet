/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class TokenizePaymentRequest
    {
        /// <summary>
        /// An alias for the token. This can be used to visually represent the token.
        /// <br />If no alias is given, a payment product specific default is used, e.g. the obfuscated card number for card payment products.
        /// <br />Do not include any unobfuscated sensitive data in the alias.
        /// </summary>
        public string Alias { get; set; }
    }
}
