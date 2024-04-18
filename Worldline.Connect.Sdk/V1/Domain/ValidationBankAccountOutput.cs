/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ValidationBankAccountOutput
    {
        /// <summary>
        /// Array of checks performed with the results of each check
        /// </summary>
        public IList<ValidationBankAccountCheck> Checks { get; set; }

        /// <summary>
        /// Bank name, matching the bank code of the request
        /// </summary>
        public string NewBankName { get; set; }

        /// <summary>
        /// Reformatted account number according to local clearing rules
        /// </summary>
        public string ReformattedAccountNumber { get; set; }

        /// <summary>
        /// Reformatted bank code according to local clearing rules
        /// </summary>
        public string ReformattedBankCode { get; set; }

        /// <summary>
        /// Reformatted branch code according to local clearing rules
        /// </summary>
        public string ReformattedBranchCode { get; set; }
    }
}
