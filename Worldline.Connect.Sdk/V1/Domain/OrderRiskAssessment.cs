/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class OrderRiskAssessment
    {
        /// <summary>
        /// Object containing additional input on the order
        /// </summary>
        public AdditionalOrderInputAirlineData AdditionalInput { get; set; }

        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Object containing the details of the customer
        /// </summary>
        public CustomerRiskAssessment Customer { get; set; }

        /// <summary>
        /// Object containing information regarding shipping / delivery
        /// </summary>
        public ShippingRiskAssessment Shipping { get; set; }
    }
}
