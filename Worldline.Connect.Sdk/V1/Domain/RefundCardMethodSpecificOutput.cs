/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RefundCardMethodSpecificOutput : RefundMethodSpecificOutput
    {
        /// <summary>
        /// Card Authorization code as returned by the acquirer
        /// </summary>
        public string AuthorisationCode { get; set; } = null;

        /// <summary>
        /// Object containing card details
        /// </summary>
        public CardEssentials Card { get; set; } = null;
    }
}
