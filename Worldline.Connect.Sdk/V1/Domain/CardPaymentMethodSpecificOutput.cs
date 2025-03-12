/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CardPaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Card Authorization code as returned by the acquirer
        /// </summary>
        public string AuthorisationCode { get; set; }

        /// <summary>
        /// Object containing card details
        /// </summary>
        public CardEssentials Card { get; set; }

        /// <summary>
        /// Fraud results contained in the CardFraudResults object
        /// </summary>
        public CardFraudResults FraudResults { get; set; }

        /// <summary>
        /// The unique scheme transactionId of the initial transaction that was performed with SCA.
        /// <br />Should be stored by the merchant to allow it to be submitted in future transactions.
        /// </summary>
        public string InitialSchemeTransactionId { get; set; }

        /// <summary>
        /// Object holding data that describes a network token.
        /// </summary>
        public NetworkTokenData NetworkTokenData { get; set; }

        /// <summary>
        /// Indicates if a network token was used during the payment.
        /// </summary>
        public bool? NetworkTokenUsed { get; set; }

        /// <summary>
        /// A unique reference to the primary account number. Payment Account Reference provides a consolidated view of transactions associated with a PAN and its affiliated tokens, making it easier to identify customers and their associated transactions across payment channels.
        /// </summary>
        public string PaymentAccountReference { get; set; }

        /// <summary>
        /// The unique scheme transactionId of this transaction.
        /// <br />Should be stored by the merchant to allow it to be submitted in future transactions. Use this value in case the initialSchemeTransactionId property is empty.
        /// </summary>
        public string SchemeTransactionId { get; set; }

        /// <summary>
        /// 3D Secure results object
        /// </summary>
        public ThreeDSecureResults ThreeDSecureResults { get; set; }

        /// <summary>
        /// If a token was used for or created during the payment, then the ID of that token.
        /// </summary>
        public string Token { get; set; }
    }
}
