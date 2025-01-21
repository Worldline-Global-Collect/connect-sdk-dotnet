/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CybersourceDecisionManager
    {
        /// <summary>
        /// Name of the clause within the applied policy that was triggered during the evaluation of this transaction.
        /// </summary>
        public string ClauseName { get; set; }

        /// <summary>
        /// Result of the Cybersource Decision Manager check. This contains the normalized fraud score from a scale of 0 to 100. A higher score indicates an increased risk of fraud.
        /// </summary>
        public int? FraudScore { get; set; }

        /// <summary>
        /// Name of the policy that was applied during the evaluation of this transaction.
        /// </summary>
        public string PolicyApplied { get; set; }

        /// <summary>
        /// List of one or more reason codes.
        /// </summary>
        public IList<string> ReasonCodes { get; set; }
    }
}
