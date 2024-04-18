/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class OrderApprovePayment
    {
        /// <summary>
        /// Object containing additional input on the order
        /// </summary>
        public AdditionalOrderInputAirlineData AdditionalInput { get; set; }

        /// <summary>
        /// Object containing data related to the customer
        /// </summary>
        public CustomerApprovePayment Customer { get; set; }

        /// <summary>
        /// Object that holds all reference properties that are linked to this transaction
        /// </summary>
        public OrderReferencesApprovePayment References { get; set; }
    }
}
