/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class Dispute
    {
        /// <summary>
        /// The ID of the capture that is being disputed.
        /// </summary>
        public string CaptureId { get; set; }

        /// <summary>
        /// This property contains the creationDetails and default information regarding a dispute.
        /// </summary>
        public DisputeOutput DisputeOutput { get; set; }

        /// <summary>
        /// Dispute ID for a given merchant.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The ID of the payment that is being disputed.
        /// </summary>
        public string PaymentId { get; set; }

        /// <summary>
        /// Current dispute status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// This property contains the output for a dispute regarding the status of the dispute.
        /// </summary>
        public DisputeStatusOutput StatusOutput { get; set; }
    }
}
