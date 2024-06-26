/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class BankAccountBban : BankAccount
    {
        /// <summary>
        /// Bank account number
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank code
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// Name of the bank
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Branch code
        /// </summary>
        public string BranchCode { get; set; }

        /// <summary>
        /// Bank check digit
        /// </summary>
        public string CheckDigit { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the country where the bank account is held For UK payouts this value is automatically set to GB as only payouts to UK accounts are supported.
        /// </summary>
        public string CountryCode { get; set; }
    }
}
