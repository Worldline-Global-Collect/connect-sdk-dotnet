/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ContactDetailsBase
    {
        /// <summary>
        /// Email address of the customer
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Preference for the type of email message markup 
        /// <list type="bullet">
        ///   <item><description>plain-text</description></item>
        ///   <item><description>html</description></item>
        /// </list>
        /// </summary>
        public string EmailMessageType { get; set; }
    }
}
