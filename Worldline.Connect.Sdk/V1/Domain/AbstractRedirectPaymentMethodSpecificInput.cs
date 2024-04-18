/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class AbstractRedirectPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public int? ExpirationPeriod { get; set; }

        public string RecurringPaymentSequenceIndicator { get; set; }

        public bool? RequiresApproval { get; set; }

        public string Token { get; set; }

        public bool? Tokenize { get; set; }
    }
}
