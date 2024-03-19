/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CreatePaymentResult
    {
        /// <summary>
        /// Object containing the details of the created payment
        /// </summary>
        public PaymentCreationOutput CreationOutput { get; set; } = null;

        /// <summary>
        /// Object that contains the action, including the needed data, that you should perform next, like showing instruction, showing the transaction results or redirect to a third party to complete the payment
        /// </summary>
        public MerchantAction MerchantAction { get; set; } = null;

        /// <summary>
        /// Object that holds the payment related properties
        /// </summary>
        public Payment Payment { get; set; } = null;
    }
}
