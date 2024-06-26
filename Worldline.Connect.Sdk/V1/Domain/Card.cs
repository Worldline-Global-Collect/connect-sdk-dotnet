/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class Card : CardWithoutCvv
    {
        /// <summary>
        /// Card Verification Value, a 3 or 4 digit code used as an additional security feature for card not present transactions.
        /// </summary>
        public string Cvv { get; set; }

        /// <summary>
        /// The first 2 digits of the card's PIN code. May be optionally submitted for South Korean cards (paymentProductIds 180, 181, 182, 183, 184, 185 and 186). Submitting this property may improve your authorization rate.
        /// </summary>
        public string PartialPin { get; set; }
    }
}
