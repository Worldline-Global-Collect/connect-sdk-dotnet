/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RedirectPaymentProduct869SpecificInput
    {
        /// <summary>
        /// ID of the issuing bank of the customer. A list of available issuerIDs can be obtained by using the retrieve payment product directory API.
        /// </summary>
        public string IssuerId { get; set; }

        /// <summary>
        /// The name as described on the Resident Identity Card of the People's Republic of China.
        /// </summary>
        public string ResidentIdName { get; set; }

        /// <summary>
        /// The identification number as described on the Resident Identity Card of the People's Republic of China.
        /// </summary>
        public string ResidentIdNumber { get; set; }
    }
}
