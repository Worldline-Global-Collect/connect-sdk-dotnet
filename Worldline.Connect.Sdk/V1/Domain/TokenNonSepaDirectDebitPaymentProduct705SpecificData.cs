/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class TokenNonSepaDirectDebitPaymentProduct705SpecificData
    {
        /// <summary>
        /// Core reference number for the direct debit instruction in UK
        /// </summary>
        public string AuthorisationId { get; set; }

        /// <summary>
        /// Object containing account holder name and bank account information
        /// </summary>
        public BankAccountBban BankAccountBban { get; set; }
    }
}
