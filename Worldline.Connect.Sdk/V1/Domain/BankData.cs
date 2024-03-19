/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class BankData
    {
        /// <summary>
        /// Bank name, matching the bank code of the request
        /// </summary>
        public string NewBankName { get; set; } = null;

        /// <summary>
        /// Reformatted account number according to local clearing rules
        /// </summary>
        public string ReformattedAccountNumber { get; set; } = null;

        /// <summary>
        /// Reformatted bank code according to local clearing rules
        /// </summary>
        public string ReformattedBankCode { get; set; } = null;

        /// <summary>
        /// Reformatted branch code according to local clearing rules
        /// </summary>
        public string ReformattedBranchCode { get; set; } = null;
    }
}
