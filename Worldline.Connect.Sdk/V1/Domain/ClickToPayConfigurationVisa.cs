/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ClickToPayConfigurationVisa : ClickToPaySchemeConfigurationBase
    {
        /// <summary>
        /// Key ID of the encryption key to encrypt card information before sending it to Visa.
        /// </summary>
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Modulus of the encryption key to encrypt card information before sending it to Visa.
        /// </summary>
        public string NModulus { get; set; }
    }
}
