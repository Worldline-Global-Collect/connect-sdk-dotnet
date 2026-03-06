/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ClickToPayConfiguration
    {
        /// <summary>
        /// Object containing Click to Pay logo display hints
        /// </summary>
        public ClickToPayDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// Scheme onboarding value returned for the card products supporting Click to Pay with Mastercard.
        /// </summary>
        public ClickToPayConfigurationMastercard Mastercard { get; set; }

        /// <summary>
        /// Scheme onboarding value returned for the card products supporting Click to Pay with Visa.
        /// </summary>
        public ClickToPayConfigurationVisa Visa { get; set; }
    }
}
