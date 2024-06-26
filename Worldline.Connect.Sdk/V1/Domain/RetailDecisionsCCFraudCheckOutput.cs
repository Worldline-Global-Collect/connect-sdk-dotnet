/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RetailDecisionsCCFraudCheckOutput
    {
        /// <summary>
        /// Provides additional information about the fraud result
        /// </summary>
        public string FraudCode { get; set; }

        /// <summary>
        /// The raw score returned by the Neural check returned by the evaluation of the transaction
        /// </summary>
        public string FraudNeural { get; set; }

        /// <summary>
        /// List of RuleCategoryFlags as setup in the Retail Decisions system that lead to the result
        /// </summary>
        public string FraudRCF { get; set; }
    }
}
