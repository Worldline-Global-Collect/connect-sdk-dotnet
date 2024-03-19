/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class TokenCardData
    {
        /// <summary>
        /// Object containing the card details (without CVV)
        /// </summary>
        public CardWithoutCvv CardWithoutCvv { get; set; } = null;

        /// <summary>
        /// Date of the first transaction (for ATOS)
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string FirstTransactionDate { get; set; } = null;

        /// <summary>
        /// Reference of the provider (of the first transaction) - used to store the ATOS Transaction Certificate
        /// </summary>
        public string ProviderReference { get; set; } = null;
    }
}
