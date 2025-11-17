/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ExternalCardholderAuthenticationData
    {
        /// <summary>
        /// Identifier of the authenticated transaction at the ACS/Issuer.
        /// </summary>
        public string AcsTransactionId { get; set; }

        /// <summary>
        /// When you request an exemptions via your non-Worldline 3D Secure provider successfully, you need to provide in this property the exemption that was granted, in combination with all 3DS results given by issuer.
        /// <br />Possible values:
        /// <list type="bullet">
        ///   <item><description>transaction-risk-analysis - You have determined that this transaction is of low risk and are willing to take the liability. Please note that your fraud rate needs to stay below thresholds to allow your use of this exemption.</description></item>
        ///   <item><description>low-value - The value of the transaction is below 30 EUR. Please note that the issuer will still require every 5th low-value transaction pithing 24 hours to be strongly authenticated. The issuer will also keep track of the cumulative amount authorized on the card. When this exceeds 100 EUR strong customer authentication is also required.</description></item>
        ///   <item><description>whitelist - You have been whitelisted by the customer at the issuer.</description></item>
        /// </list>
        /// </summary>
        public string AppliedExemption { get; set; }

        /// <summary>
        /// The CAVV (cardholder authentication verification value) or AAV (accountholder authentication value) provides an authentication validation value.
        /// </summary>
        public string Cavv { get; set; }

        /// <summary>
        /// The algorithm, from your 3D Secure provider, used to generate the authentication CAVV.
        /// </summary>
        public string CavvAlgorithm { get; set; }

        /// <summary>
        /// The 3-D Secure Directory Server transaction ID that is used for the 3D Authentication
        /// </summary>
        public string DirectoryServerTransactionId { get; set; }

        /// <summary>
        /// Electronic Commerce Indicator provides authentication validation results returned after AUTHENTICATIONVALIDATION 
        /// <list type="bullet">
        ///   <item><description>0 = No authentication, Internet (no liability shift, not a 3D Secure transaction)</description></item>
        ///   <item><description>1 = Authentication attempted (MasterCard)</description></item>
        ///   <item><description>2 = Successful authentication (MasterCard)</description></item>
        ///   <item><description>5 = Successful authentication (Visa, Diners Club, Amex)</description></item>
        ///   <item><description>6 = Authentication attempted (Visa, Diners Club, Amex)</description></item>
        ///   <item><description>7 = No authentication, Internet (no liability shift, not a 3D Secure transaction)</description></item>
        ///   <item><description>(empty) = Not checked or not enrolled</description></item>
        /// </list>
        /// </summary>
        public int? Eci { get; set; }

        /// <summary>
        /// Global score calculated by the Carte Bancaire (130) Scoring platform. Possible values from 0 to 99.
        /// </summary>
        public int? SchemeRiskScore { get; set; }

        /// <summary>
        /// The 3-D Secure version used for the authentication. Possible values: 
        /// <list type="bullet">
        ///   <item><description>v1</description></item>
        ///   <item><description>v2</description></item>
        ///   <item><description>1.0.2</description></item>
        ///   <item><description>2.1.0</description></item>
        ///   <item><description>2.2.0</description></item>
        ///   <item><description>2.3</description></item>
        ///   <item><description>2.3.0</description></item>
        ///   <item><description>2.3.1</description></item>
        ///   <item><description>2.3.1.1</description></item>
        /// </list>
        /// </summary>
        public string ThreeDSecureVersion { get; set; }

        /// <summary>
        /// The 3-D Secure Server transaction ID that is used for the 3-D Secure version 2 Authentication.
        /// </summary>
        [Obsolete("No replacement")]
        public string ThreeDServerTransactionId { get; set; }

        /// <summary>
        /// The 3D Secure authentication result from your 3D Secure provider.
        /// </summary>
        public string ValidationResult { get; set; }

        /// <summary>
        /// The transaction ID that is used for the 3D Authentication
        /// </summary>
        public string Xid { get; set; }
    }
}
