/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ContactDetails : ContactDetailsBase
    {
        /// <summary>
        /// Fax number of the customer
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// International version of the mobile phone number of the customer including the leading + (i.e. +16127779311).
        /// </summary>
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Phone number of the customer. The '+' character is not allowed in this property for transactions that are processed by TechProcess Payment Platform.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// International version of the work phone number of the customer including the leading + (i.e. +31235671500)
        /// </summary>
        public string WorkPhoneNumber { get; set; }
    }
}
