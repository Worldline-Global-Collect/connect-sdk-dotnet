/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class FraudResultsRetailDecisions
    {
        /// <summary>
        /// Result of the fraud service. Provides additional information about the fraud result
        /// </summary>
        public string FraudCode { get; set; }

        /// <summary>
        /// Returns the raw score of the neural
        /// </summary>
        public string FraudNeural { get; set; }

        /// <summary>
        /// Result of the fraud service Represent sets of fraud rules returned during the evaluation of the transaction
        /// </summary>
        public string FraudRCF { get; set; }
    }
}
