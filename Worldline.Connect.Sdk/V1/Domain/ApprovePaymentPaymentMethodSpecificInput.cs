/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ApprovePaymentPaymentMethodSpecificInput
    {
        /// <summary>
        /// The desired date for the collection
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string DateCollect { get; set; } = null;

        /// <summary>
        /// Token containing tokenized bank account details
        /// </summary>
        public string Token { get; set; } = null;
    }
}
