/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class AbstractCardPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public string AcquirerPromotionCode { get; set; }

        public string AuthorizationMode { get; set; }

        public string CustomerReference { get; set; }

        public string InitialSchemeTransactionId { get; set; }

        public CardRecurrenceDetails Recurring { get; set; }

        [Obsolete("Use recurring.recurringPaymentSequenceIndicator instead")]
        public string RecurringPaymentSequenceIndicator { get; set; }

        public bool? RequiresApproval { get; set; }

        [Obsolete("Use threeDSecure.skipAuthentication instead")]
        public bool? SkipAuthentication { get; set; }

        public bool? SkipFraudService { get; set; }

        public string Token { get; set; }

        public bool? Tokenize { get; set; }

        public string TransactionChannel { get; set; }

        [Obsolete("Use unscheduledCardOnFileSequenceIndicator instead")]
        public string UnscheduledCardOnFileIndicator { get; set; }

        public string UnscheduledCardOnFileRequestor { get; set; }

        public string UnscheduledCardOnFileSequenceIndicator { get; set; }
    }
}
