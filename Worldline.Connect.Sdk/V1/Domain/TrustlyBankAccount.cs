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
        public string AccountLastDigits { get; set; }

        /// <summary>
        /// The name of the bank
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// The country of the clearing house
        /// </summary>
        public string Clearinghouse { get; set; }

        /// <summary>
        /// The ID number of the account holder
        /// </summary>
        public string PersonIdentificationNumber { get; set; }
    }
}
