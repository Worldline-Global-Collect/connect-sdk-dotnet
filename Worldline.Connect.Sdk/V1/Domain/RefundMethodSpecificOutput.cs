/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RefundMethodSpecificOutput
    {
        /// <summary>
        /// Refund product identifier
        /// <br />Please see 
        /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/refundproducts.html">refund products</a> for a full overview of possible values.
        /// </summary>
        public int? RefundProductId { get; set; } = null;

        /// <summary>
        /// Total paid amount (in cents and always with 2 decimals)
        /// </summary>
        public long? TotalAmountPaid { get; set; } = null;

        public long? TotalAmountRefunded { get; set; } = null;
    }
}
