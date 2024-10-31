/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CardEssentials
    {
        /// <summary>
        /// The complete credit/debit card number
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// The card holder's name on the card. Minimum length of 2, maximum length of 51 characters.
        /// </summary>
        public string CardholderName { get; set; }

        /// <summary>
        /// Expiry date of the card
        /// <br />Format: MMYY
        /// </summary>
        public string ExpiryDate { get; set; }
    }
}
