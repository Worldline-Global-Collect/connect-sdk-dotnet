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
        /// Current high-level status of the captures in a human-readable form. Possible values are:
        /// <list type="bullet">
        ///   <item><description>CREATED - The capture has been created on our side</description></item>
        ///   <item><description>CAPTURE_REQUESTED - The transaction is in the queue to be captured</description></item>
        ///   <item><description>CAPTURED - The transaction has been captured and we have received online confirmation</description></item>
        ///   <item><description>PAID - We have matched the incoming funds to the transaction</description></item>
        ///   <item><description>CANCELLED - You have cancelled the capture</description></item>
        ///   <item><description>REJECTED_CAPTURE - The capture has been rejected</description></item>
        ///   <item><description>REVERSED - The capture has been reversed</description></item>
        ///   <item><description>CHARGEBACK_NOTIFICATION - We have received a notification of chargeback and this status informs you that your account will be debited for a particular transaction</description></item>
        ///   <item><description>CHARGEBACKED - The transaction has been chargebacked</description></item>
        /// </list>
        /// <br />Please see 
        /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/statuses.html">Statuses</a> for a full overview of possible values.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// This object has the numeric representation of the current capture status, timestamp of last status change and performable action on the current capture resource. In case of failed captures and negative scenarios, detailed error information is listed.
        /// </summary>
        public CaptureStatusOutput StatusOutput { get; set; }
    }
}
