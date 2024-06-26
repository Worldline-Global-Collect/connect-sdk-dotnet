/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class UpdateTokenRequest
    {
        /// <summary>
        /// Object containing card details
        /// </summary>
        public TokenCard Card { get; set; }

        /// <summary>
        /// Object containing eWallet details
        /// </summary>
        public TokenEWallet EWallet { get; set; }

        /// <summary>
        /// Object containing the non SEPA Direct Debit details
        /// </summary>
        public TokenNonSepaDirectDebit NonSepaDirectDebit { get; set; }

        /// <summary>
        /// Payment product identifier
        /// <br />Please see 
        /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/paymentproducts.html">payment products</a> for a full overview of possible values.
        /// </summary>
        public int? PaymentProductId { get; set; }

        /// <summary>
        /// Object containing the SEPA Direct Debit details
        /// </summary>
        public TokenSepaDirectDebitWithoutCreditor SepaDirectDebit { get; set; }
    }
}
