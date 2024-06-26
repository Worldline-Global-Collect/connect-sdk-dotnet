/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PersonalInformation
    {
        /// <summary>
        /// The date of birth of the customer
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// The gender of the customer, possible values are: 
        /// <list type="bullet">
        ///   <item><description>male</description></item>
        ///   <item><description>female</description></item>
        ///   <item><description>unknown or empty</description></item>
        /// </list>
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Object containing identification documents information
        /// </summary>
        public PersonalIdentification Identification { get; set; }

        /// <summary>
        /// Object containing the name details of the customer
        /// </summary>
        public PersonalName Name { get; set; }
    }
}
