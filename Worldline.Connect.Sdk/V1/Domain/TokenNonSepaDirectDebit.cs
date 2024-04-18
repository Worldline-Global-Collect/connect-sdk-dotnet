/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class TokenNonSepaDirectDebit : AbstractToken
    {
        /// <summary>
        /// Object containing the details of the customer
        /// </summary>
        public CustomerToken Customer { get; set; }

        /// <summary>
        /// Object containing the mandate details
        /// </summary>
        public MandateNonSepaDirectDebit Mandate { get; set; }
    }
}
