/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentContext
    {
        /// <summary>
        /// The payment amount
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// The country the payment takes place in
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// True if the payment is to be paid in multiple installments (numberOfInstallments &gt; 1 for the payment). When true only payment products that support installments will be allowed in context.
        /// </summary>
        public bool? IsInstallments { get; set; }

        /// <summary>
        /// True if the payment is recurring
        /// </summary>
        public bool? IsRecurring { get; set; }
    }
}
