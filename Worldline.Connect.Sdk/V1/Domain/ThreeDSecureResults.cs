/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ThreeDSecureResults
    {
        /// <summary>
        /// Identifier of the authenticated transaction at the ACS/Issuer
        /// </summary>
        public string AcsTransactionId { get; set; }

        /// <summary>
        /// Exemption code from Carte Bancaire (130) (unknown possible values so far -free format)
        /// </summary>
        public string AppliedExemption { get; set; }

        /// <summary>
        /// The amount for which this transaction has been authenticated.
        /// </summary>
        public AmountOfMoney AuthenticationAmount { get; set; }

        /// <summary>
        /// CAVV or AVV result indicating authentication validation value
        /// </summary>
        public string Cavv { get; set; }

        /// <summary>
        /// The 3-D Secure Directory Server transaction ID that is used for the 3D Authentication
        /// </summary>
        public string DirectoryServerTransactionId { get; set; }

        /// <summary>
        /// Indicates Authentication validation results returned after AuthenticationValidation
        /// </summary>
        public string Eci { get; set; }

        /// <summary>
        /// Object containing exemption output
        /// </summary>
        public ExemptionOutput ExemptionOutput { get; set; }

        /// <summary>
        /// Global score calculated by the Carte Bancaire (130) Scoring platform. Possible values from 0 to 99
        /// </summary>
        public int? SchemeRiskScore { get; set; }

        /// <summary>
        /// Object containing 3-D Secure in-app SDK data
        /// </summary>
        public SdkDataOutput SdkData { get; set; }

        /// <summary>
        /// Object containing data regarding the 3-D Secure authentication
        /// </summary>
        public ThreeDSecureData ThreeDSecureData { get; set; }

        /// <summary>
        /// The 3-D Secure version used for the authentication. 
        /// <p>This property is used in the communication with the acquirer</p>
        /// </summary>
        public string ThreeDSecureVersion { get; set; }

        /// <summary>
        /// The 3-D Secure Server transaction ID that is used for the 3-D Secure version 2 Authentication.
        /// </summary>
        public string ThreeDServerTransactionId { get; set; }

        /// <summary>
        /// Transaction ID for the Authentication
        /// </summary>
        public string Xid { get; set; }
    }
}
