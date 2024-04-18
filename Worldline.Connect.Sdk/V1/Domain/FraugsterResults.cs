/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class FraugsterResults
    {
        /// <summary>
        /// Result of the Fraugster check Contains the investigation points used during the evaluation
        /// </summary>
        public string FraudInvestigationPoints { get; set; }

        /// <summary>
        /// Result of the Fraugster check Contains the overall Fraud score which is an integer between 0 and 99
        /// </summary>
        public int? FraudScore { get; set; }
    }
}
