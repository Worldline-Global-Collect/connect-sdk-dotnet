/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class TokenSepaDirectDebitWithoutCreditor : AbstractToken
    {
        /// <summary>
        /// Object containing the details of the customer
        /// </summary>
        public CustomerTokenWithContactDetails Customer { get; set; }

        /// <summary>
        /// Object containing the mandate details
        /// </summary>
        public MandateSepaDirectDebitWithoutCreditor Mandate { get; set; }
    }
}
