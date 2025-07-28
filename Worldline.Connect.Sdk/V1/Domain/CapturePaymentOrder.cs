/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CapturePaymentOrder
    {
        /// <summary>
        /// Object containing additional input on the order
        /// </summary>
        public CapturePaymentOrderAdditionalInput AdditionalInput { get; set; }

        /// <summary>
        /// Object that holds all reference properties that are linked to this transaction
        /// </summary>
        public CapturePaymentOrderReferences References { get; set; }
    }
}
