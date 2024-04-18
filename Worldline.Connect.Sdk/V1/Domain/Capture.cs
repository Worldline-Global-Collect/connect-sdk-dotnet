/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class Capture : AbstractOrderStatus
    {
        /// <summary>
        /// Object containing capture details
        /// </summary>
        public CaptureOutput CaptureOutput { get; set; }

        /// <summary>
        /// Current high-level status of the payment in a human-readable form. Possible values are : 
        /// <list type="bullet">
        ///   <item><description>CAPTURE_REQUESTED - The transaction is in the queue to be captured.</description></item>
        ///   <item><description>CAPTURED - The transaction has been captured and we have received online confirmation.</description></item>
        ///   <item><description>CANCELLED - You have cancelled the transaction.</description></item>
        ///   <item><description>REJECTED_CAPTURE - We or one of our downstream acquirers/providers have rejected the capture request.</description></item>
        ///   <item><description>REVERSED - The transaction has been reversed.</description></item>
        /// </list>
        /// <br />Please see 
        /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/statuses.html">Statuses</a> for a full overview of possible values.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// This object has the numeric representation of the current capture status, timestamp of last status change and performable action on the current payment resource. In case of failed payments and negative scenarios, detailed error information is listed.
        /// </summary>
        public CaptureStatusOutput StatusOutput { get; set; }
    }
}
