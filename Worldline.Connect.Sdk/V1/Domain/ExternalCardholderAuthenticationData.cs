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
        /// <p>
        /// <strong>ECI (Electronic Commerce Indicator)</strong> indicates the level of authentication obtained for a transaction. Possible values for each level of authentication are listed below.</p>
        /// <list type="bullet">
        ///   <item><description>
        ///   <strong>For ValidationResult = Y (Successful Authentication)</strong> 
        ///   <list type="bullet">
        ///     <item><description>MC &#8594; ECI 02</description></item>
        ///     <item><description>Visa, CB, Amex, JCB, DCI, UPI &#8594; ECI 05</description></item>
        ///   </list></description></item>
        ///   <item><description>
        ///   <strong>For ValidationResult = A (Attempt)</strong> 
        ///   <list type="bullet">
        ///     <item><description>MC &#8594; ECI 01</description></item>
        ///     <item><description>MC &#8594; ECI 04</description></item>
        ///     <item><description>Visa, Amex, JCB, DCI, UPI &#8594; ECI 06</description></item>
        ///     <item><description>CB &#8594; 06 (or null from ACS - populate as 06)</description></item>
        ///   </list></description></item>
        ///   <item><description>
        ///   <strong>For ValidationResult = I (Exemption Accepted)</strong>- for all below values, ECI must be sent with the resulted CAVV 
        ///   <list type="bullet">
        ///     <item><description>MC &#8594; ECI 06 (PSD2 Exemption)</description></item>
        ///     <item><description>Visa &#8594; ECI 07 (TRA Exemption) or ECI 05 (other exemptions)</description></item>
        ///     <item><description>CB, JCB, UPI &#8594; ECI 05</description></item>
        ///     <item><description>Amex, DCI &#8594; ECI 05/0</description></item>
        ///   </list></description></item>
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
        /// The transaction status given by the 3D Secure provider. Possible values below: 
        /// <list type="bullet">
        ///   <item><description>Y: Cardholder successfully authenticated</description></item>
        ///   <item><description>A: Authentication attempt (merchant attempted, issuer not participating or ACS unavailable)</description></item>
        ///   <item><description>I: Informational only (SCA exemption accepted)</description></item>
        /// </list>
        /// </summary>
        public string ValidationResult { get; set; }

        /// <summary>
        /// The transaction ID that is used for the 3D Authentication
        /// </summary>
        public string Xid { get; set; }
    }
}
