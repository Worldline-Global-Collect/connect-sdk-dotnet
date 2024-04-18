/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class AirlinePassenger
    {
        /// <summary>
        /// First name of the passenger (this property is used for fraud screening on the Ogone Payment Platform)
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Surname of the passenger (this property is used for fraud screening on the Ogone Payment Platform)
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Surname prefix of the passenger (this property is used for fraud screening on the Ogone Payment Platform)
        /// </summary>
        public string SurnamePrefix { get; set; }

        /// <summary>
        /// Title of the passenger (this property is used for fraud screening on the Ogone Payment Platform)
        /// </summary>
        public string Title { get; set; }
    }
}
