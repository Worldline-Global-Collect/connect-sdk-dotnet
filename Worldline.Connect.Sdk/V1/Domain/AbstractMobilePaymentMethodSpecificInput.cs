/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class AbstractMobilePaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public string AuthorizationMode { get; set; }

        public string CustomerReference { get; set; }

        public string InitialSchemeTransactionId { get; set; }

        public CardRecurrenceDetails Recurring { get; set; }

        public bool? RequiresApproval { get; set; }

        public bool? SkipFraudService { get; set; }

        public string Token { get; set; }

        public bool? Tokenize { get; set; }

        public string UnscheduledCardOnFileRequestor { get; set; }

        public string UnscheduledCardOnFileSequenceIndicator { get; set; }
    }
}
