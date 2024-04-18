/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RefundRequest
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Object containing the specific input details for a bank refund
        /// </summary>
        public BankRefundMethodSpecificInput BankRefundMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the details of the customer
        /// </summary>
        public RefundCustomer Customer { get; set; }

        /// <summary>
        /// Refund date
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string RefundDate { get; set; }

        /// <summary>
        /// Object that holds all reference properties that are linked to this refund
        /// </summary>
        public RefundReferences RefundReferences { get; set; }
    }
}
