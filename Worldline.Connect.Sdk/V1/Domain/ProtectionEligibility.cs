/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ProtectionEligibility
    {
        /// <summary>
        /// Possible values: 
        /// <list type="bullet">
        ///   <item><description>Eligible</description></item>
        ///   <item><description>PartiallyEligible</description></item>
        ///   <item><description>Ineligible</description></item>
        /// </list>
        /// </summary>
        public string Eligibility { get; set; }

        /// <summary>
        /// Possible values: 
        /// <list type="bullet">
        ///   <item><description>ItemNotReceivedEligible</description></item>
        ///   <item><description>UnauthorizedPaymentEligible</description></item>
        ///   <item><description>Ineligible</description></item>
        /// </list>
        /// </summary>
        public string Type { get; set; }
    }
}
