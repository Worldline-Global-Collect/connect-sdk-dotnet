/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProduct806SpecificOutput
    {
        /// <summary>
        /// Object containing the billing address details of the customer
        /// </summary>
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Object containing the account details
        /// </summary>
        public TrustlyBankAccount CustomerAccount { get; set; }
    }
}
