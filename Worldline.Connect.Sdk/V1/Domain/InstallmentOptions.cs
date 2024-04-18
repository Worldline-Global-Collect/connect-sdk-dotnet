/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class InstallmentOptions
    {
        /// <summary>
        /// Object containing information for the client on how best to display the installment options
        /// </summary>
        public InstallmentDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// The ID of the installment option in our system
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Object containing information about installment plans
        /// </summary>
        public IList<Installments> InstallmentPlans { get; set; }
    }
}
