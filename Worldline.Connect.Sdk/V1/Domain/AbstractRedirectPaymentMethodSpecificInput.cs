/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class AbstractRedirectPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public int? ExpirationPeriod { get; set; } = null;

        public string RecurringPaymentSequenceIndicator { get; set; } = null;

        public bool? RequiresApproval { get; set; } = null;

        public string Token { get; set; } = null;

        public bool? Tokenize { get; set; } = null;
    }
}
