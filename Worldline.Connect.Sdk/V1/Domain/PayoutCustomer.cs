/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PayoutCustomer
    {
        /// <summary>
        /// Object containing address details
        /// </summary>
        public Address Address { get; set; } = null;

        /// <summary>
        /// Object containing company information
        /// </summary>
        public CompanyInformation CompanyInformation { get; set; } = null;

        /// <summary>
        /// Object containing contact details like email address and phone number
        /// </summary>
        public ContactDetailsBase ContactDetails { get; set; } = null;

        /// <summary>
        /// Your identifier for the customer. It can be used as a search criteria in the GlobalCollect Payment Console and is also included in the GlobalCollect report files. It is used in the fraud-screening process for payments on the Ogone Payment Platform.
        /// </summary>
        public string MerchantCustomerId { get; set; } = null;

        /// <summary>
        /// Object containing PersonalName object
        /// </summary>
        public PersonalName Name { get; set; } = null;
    }
}
