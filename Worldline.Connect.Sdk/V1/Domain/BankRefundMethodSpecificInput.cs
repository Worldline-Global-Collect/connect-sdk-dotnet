/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class BankRefundMethodSpecificInput
    {
        /// <summary>
        /// Object that holds the Basic Bank Account Number (BBAN) data
        /// </summary>
        public BankAccountBbanRefund BankAccountBban { get; set; }

        /// <summary>
        /// Object that holds the International Bank Account Number (IBAN) data
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the country where money will be refunded to
        /// </summary>
        public string CountryCode { get; set; }
    }
}
