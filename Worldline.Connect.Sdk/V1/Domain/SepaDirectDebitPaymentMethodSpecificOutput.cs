/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class SepaDirectDebitPaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Object containing the results of the fraud screening
        /// </summary>
        public FraudResults FraudResults { get; set; }

        /// <summary>
        /// Output that is SEPA Direct Debit specific (i.e. the used mandate)
        /// </summary>
        public PaymentProduct771SpecificOutput PaymentProduct771SpecificOutput { get; set; }

        /// <summary>
        /// ID of the token. This property is populated for the GlobalCollect payment platform when the payment was done with a token or when the payment was tokenized.
        /// </summary>
        public string Token { get; set; }
    }
}
