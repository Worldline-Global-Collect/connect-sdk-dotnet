/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class TokenCard : AbstractToken
    {
        /// <summary>
        /// Object containing the details of the customer
        /// </summary>
        public CustomerToken Customer { get; set; } = null;

        /// <summary>
        /// Object containing the card tokenizable details
        /// </summary>
        public TokenCardData Data { get; set; } = null;
    }
}
