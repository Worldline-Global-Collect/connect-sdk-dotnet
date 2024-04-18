/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class TokenEWallet : AbstractToken
    {
        /// <summary>
        /// Object containing the details of the customer
        /// </summary>
        public CustomerToken Customer { get; set; }

        /// <summary>
        /// Object containing the eWallet tokenizable data
        /// </summary>
        public TokenEWalletData Data { get; set; }
    }
}
