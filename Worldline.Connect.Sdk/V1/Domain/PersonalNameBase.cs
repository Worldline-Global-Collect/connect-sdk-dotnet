/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PersonalNameBase
    {
        /// <summary>
        /// Given name(s) or first name(s) of the customer
        /// </summary>
        public string FirstName { get; set; } = null;

        public string Surname { get; set; } = null;

        /// <summary>
        /// Middle name - In between first name and surname - of the customer
        /// </summary>
        public string SurnamePrefix { get; set; } = null;
    }
}
