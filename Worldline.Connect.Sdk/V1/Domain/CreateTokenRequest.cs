/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CreateTokenRequest
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
        /// Data that was encrypted client side containing all customer entered data elements like card data.
        /// <br />Note: Because this data can only be submitted once to our system and contains encrypted card data you should not store it. As the data was captured within the context of a client session you also need to submit it to us before the session has expired.
        /// </summary>
        public string EncryptedCustomerInput { get; set; }

        /// <summary>
        /// Object containing non SEPA Direct Debit details
        /// </summary>
        public TokenNonSepaDirectDebit NonSepaDirectDebit { get; set; }

        /// <summary>
        /// Payment product identifier
        /// <br />Please see 
        /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/paymentproducts.html">payment products</a> for a full overview of possible values.
        /// </summary>
        public int? PaymentProductId { get; set; }

        /// <summary>
        /// Object containing SEPA Direct Debit details
        /// </summary>
        public TokenSepaDirectDebitWithoutCreditor SepaDirectDebit { get; set; }
    }
}
