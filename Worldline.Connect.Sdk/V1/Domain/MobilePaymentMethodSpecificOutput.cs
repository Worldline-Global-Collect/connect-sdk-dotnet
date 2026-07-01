/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MobilePaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Card Authorization code as returned by the acquirer
        /// </summary>
        public string AuthorisationCode { get; set; }

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
        /// The network that was used for the refund
        /// </summary>
        public string Network { get; set; }

        /// <summary>
        /// The unique Mastercard transactionLinkId of the initial transaction. Strongly advised to be submitted for any merchantInitiated (unscheduledCardOnFileRequestor) or recurring transaction (recurringPaymentSequenceIndicator set to recurring or in case of a last recurring transaction to last).
        /// <br />
        /// <br />If the originalTransactionLinkId is empty, we will, where possible, apply the best available match.
        /// </summary>
        public string OriginalTransactionLinkId { get; set; }

        /// <summary>
        /// Object containing payment details
        /// </summary>
        public MobilePaymentData PaymentData { get; set; }

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

        /// <summary>
        /// The unique Mastercard transactionLinkId of this transaction.
        /// <br />Should be stored by you for a first cardholderInitiated (unscheduledCardOnFileRequestor) or zero-value authorization transaction.
        /// <br />
        /// <br />Use this value as the originalTransactionLinkId for any subsequent merchantInitiated (unscheduledCardOnFileRequestor) or recurring transaction (recurringPaymentSequenceIndicator set to recurring or in case of a last recurring transaction to last).
        /// </summary>
        public string TransactionLinkId { get; set; }
    }
}
