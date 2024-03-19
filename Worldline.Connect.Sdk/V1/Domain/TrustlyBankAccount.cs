/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class TrustlyBankAccount
    {
        /// <summary>
        /// The last digits of the account number
        /// </summary>
        public string AccountLastDigits { get; set; } = null;

        /// <summary>
        /// The name of the bank
        /// </summary>
        public string BankName { get; set; } = null;

        /// <summary>
        /// The country of the clearing house
        /// </summary>
        public string Clearinghouse { get; set; } = null;

        /// <summary>
        /// The ID number of the account holder
        /// </summary>
        public string PersonIdentificationNumber { get; set; } = null;
    }
}
