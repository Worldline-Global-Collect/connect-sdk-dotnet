/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProduct840CustomerAccount
    {
        /// <summary>
        /// Username with which the PayPal account holder has registered at PayPal
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Identification of the PayPal recurring billing agreement
        /// </summary>
        public string BillingAgreementId { get; set; }

        /// <summary>
        /// Name of the company in case the PayPal account is owned by a business
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// The phone number of the PayPal account holder
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// Country where the PayPal account is located
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Status of the PayPal account.
        /// <br />Possible values are: 
        /// <list type="bullet">
        ///   <item><description>verified - PayPal has verified the funding means for this account</description></item>
        ///   <item><description>unverified - PayPal has not verified the funding means for this account</description></item>
        /// </list>
        /// </summary>
        public string CustomerAccountStatus { get; set; }

        /// <summary>
        /// Status of the customer's shipping address as registered by PayPal
        /// <br />Possible values are: 
        /// <list type="bullet">
        ///   <item><description>none - Status is unknown at PayPal</description></item>
        ///   <item><description>confirmed - The address has been confirmed</description></item>
        ///   <item><description>unconfirmed - The address has not been confirmed</description></item>
        /// </list>
        /// </summary>
        public string CustomerAddressStatus { get; set; }

        /// <summary>
        /// First name of the PayPal account holder
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The unique identifier of a PayPal account and will never change in the life cycle of a PayPal account
        /// </summary>
        public string PayerId { get; set; }

        /// <summary>
        /// Surname of the PayPal account holder
        /// </summary>
        public string Surname { get; set; }
    }
}
