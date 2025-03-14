/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class FraudResults
    {
        /// <summary>
        /// This object contains the results of the Cybersource Decision Manager assessment. Cybersource is a fraud detection tool leveraging data networks, configurable rules, intelligence, and device fingerprinting to identify risky transactions.
        /// </summary>
        public CybersourceDecisionManager CybersourceDecisionManager { get; set; }

        /// <summary>
        /// Results from the fraud prevention check. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>accepted - Based on the checks performed the transaction can be accepted</description></item>
        ///   <item><description>challenged - Based on the checks performed the transaction should be manually reviewed</description></item>
        ///   <item><description>denied - Based on the checks performed the transaction should be rejected</description></item>
        ///   <item><description>no-advice - No fraud check was requested/performed</description></item>
        ///   <item><description>error - The fraud check resulted in an error and the fraud check was thus not performed</description></item>
        /// </list>
        /// </summary>
        public string FraudServiceResult { get; set; }

        /// <summary>
        /// Object containing device fingerprinting details from InAuth
        /// </summary>
        public InAuth InAuth { get; set; }

        /// <summary>
        /// This object contains the results of Microsoft Fraud Protection risk assessment. Microsoft collects transaction data points and uses Adaptive AI that continuously learns to protect you against payment fraud, and the device fingerprinting details from the Microsoft Device Fingerprinting service.
        /// </summary>
        public MicrosoftFraudResults MicrosoftFraudProtection { get; set; }
    }
}
