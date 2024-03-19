/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CreateMandateResponse
    {
        /// <summary>
        /// Object containing information on a mandate
        /// </summary>
        public MandateResponse Mandate { get; set; } = null;

        /// <summary>
        /// Object that contains the action, including the needed data, that you should perform next, showing the redirect to a third party to complete the payment or like showing instructions
        /// </summary>
        public MandateMerchantAction MerchantAction { get; set; } = null;
    }
}
