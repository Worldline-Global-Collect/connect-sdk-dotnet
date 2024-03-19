/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ThreeDSecure : AbstractThreeDSecure
    {
        /// <summary>
        /// Object containing 3D secure details.
        /// </summary>
        public ExternalCardholderAuthenticationData ExternalCardholderAuthenticationData { get; set; } = null;

        /// <summary>
        /// Object containing browser specific redirection related data
        /// </summary>
        public RedirectionData RedirectionData { get; set; } = null;
    }
}
