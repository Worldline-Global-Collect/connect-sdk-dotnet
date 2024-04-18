/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ExemptionOutput
    {
        /// <summary>
        /// Type of strong customer authentication (SCA) exemption that was raised towards the acquirer for this transaction.
        /// </summary>
        public string ExemptionRaised { get; set; }

        /// <summary>
        /// The request exemption could not be granted. The reason why is returned in this property.
        /// </summary>
        public string ExemptionRejectionReason { get; set; }

        /// <summary>
        /// Type of strong customer authentication (SCA) exemption requested by you for this transaction.
        /// </summary>
        public string ExemptionRequest { get; set; }
    }
}
