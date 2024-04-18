/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProduct840SpecificOutput
    {
        /// <summary>
        /// Object containing the billing address details of the customer
        /// </summary>
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Object containing the details of the PayPal account
        /// </summary>
        public PaymentProduct840CustomerAccount CustomerAccount { get; set; }

        /// <summary>
        /// Object containing the address details of the customer
        /// </summary>
        public Address CustomerAddress { get; set; }

        /// <summary>
        /// Protection Eligibility data of the PayPal customer
        /// </summary>
        public ProtectionEligibility ProtectionEligibility { get; set; }
    }
}
