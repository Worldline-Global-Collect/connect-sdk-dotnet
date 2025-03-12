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
        /// The first 2 digits of the card's PIN code. May be optionally submitted for the following payment products: 
        /// <list type="bullet">
        ///   <item><description>BC Card (paymentProductId 180)</description></item>
        ///   <item><description>Hana Card (paymentProductId 181)</description></item>
        ///   <item><description>Hyundai Card (paymentProductId 182)</description></item>
        ///   <item><description>KB Card (paymentProductId 183)</description></item>
        ///   <item><description>Lotte Card (paymentProductId 184)</description></item>
        ///   <item><description>NH Card (paymentProductId 185)</description></item>
        ///   <item><description>Samsung Card (paymentProductId 186)</description></item>
        ///   <item><description>Shinhan Card (paymentProductId 187)</description></item>
        /// </list>Submitting this property may improve your authorization rate.
        /// </summary>
        public string PartialPin { get; set; }
    }
}
