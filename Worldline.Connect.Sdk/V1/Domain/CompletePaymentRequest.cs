/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CompletePaymentRequest
    {
        /// <summary>
        /// Object containing the specific input details for card payments
        /// </summary>
        public CompletePaymentCardPaymentMethodSpecificInput CardPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing information on you, the merchant
        /// </summary>
        public Merchant Merchant { get; set; } = null;

        /// <summary>
        /// Order object containing order related data
        /// </summary>
        public Order Order { get; set; } = null;
    }
}
