/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MandateCustomer
    {
        /// <summary>
        /// Object containing IBAN information
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; } = null;

        /// <summary>
        /// Name of company, as a customer
        /// </summary>
        public string CompanyName { get; set; } = null;

        /// <summary>
        /// Object containing contact details like email address and phone number
        /// </summary>
        public MandateContactDetails ContactDetails { get; set; } = null;

        /// <summary>
        /// Object containing billing address details
        /// </summary>
        public MandateAddress MandateAddress { get; set; } = null;

        /// <summary>
        /// Object containing personal information of the customer
        /// </summary>
        public MandatePersonalInformation PersonalInformation { get; set; } = null;
    }
}
