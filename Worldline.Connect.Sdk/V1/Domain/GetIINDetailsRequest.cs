/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class GetIINDetailsRequest
    {
        /// <summary>
        /// The first digits of the credit card number from left to right with a minimum of 6 digits. Providing additional digits can result in more co-brands being returned.
        /// </summary>
        public string Bin { get; set; }

        /// <summary>
        /// Optional payment context to refine the IIN lookup to filter out payment products not applicable to your payment.
        /// </summary>
        public PaymentContext PaymentContext { get; set; }
    }
}
