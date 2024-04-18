/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MobilePaymentProductSession302SpecificInput
    {
        /// <summary>
        /// Used as an input for the Apple Pay payment button. Provide your company name in a human readable form.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Provide a fully qualified domain name of your own payment page that will be showing an Apple Pay button.
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Provide the validation URL that has been provided by Apple once you have started an Apple Pay session.
        /// </summary>
        public string ValidationUrl { get; set; }
    }
}
