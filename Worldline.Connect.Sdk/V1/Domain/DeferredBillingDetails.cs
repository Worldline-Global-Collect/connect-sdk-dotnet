/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class DeferredBillingDetails : BaseBillingDetails
    {
        /// <summary>
        /// Amount in cents and always having 2 decimals. The amount to be paid on the deferred payment date. If omitted, defaults to the total order amount.
        /// </summary>
        public long? DeferredPaymentAmount { get; set; }

        /// <summary>
        /// The date of the payment in in YYYYMMDD format that will take place in the future.
        /// </summary>
        public string DeferredPaymentDate { get; set; }

        /// <summary>
        /// The date until which customers can cancel their recurring payment without charges in YYYYMMDDHH24MISS format.
        /// </summary>
        public string FreeCancellationDate { get; set; }

        /// <summary>
        /// The IANA timezone identifier that provides the correct local context for interpreting the free cancellation deadline displayed on the payment sheet.
        /// </summary>
        public string FreeCancellationDateTimeZone { get; set; }
    }
}
