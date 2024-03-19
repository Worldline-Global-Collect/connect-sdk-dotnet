/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CustomerToken : CustomerBase
    {
        /// <summary>
        /// Object containing the billing address details
        /// </summary>
        public Address BillingAddress { get; set; } = null;

        /// <summary>
        /// Object containing personal information of the customer
        /// </summary>
        public PersonalInformationToken PersonalInformation { get; set; } = null;
    }
}
