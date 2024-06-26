/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class GetCustomerDetailsResponse
    {
        /// <summary>
        /// The city in which the customer resides.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The country in which the customer resides.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The email address registered to the customer.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The first name of the customer
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The fiscal number (SSN) for the customer.
        /// </summary>
        public string FiscalNumber { get; set; }

        /// <summary>
        /// The code of the language used by the customer.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// The phone number registered to the customer.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The street on which the customer resides.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The surname or family name of the customer.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// The ZIP or postal code for the area in which the customer resides.
        /// </summary>
        public string Zip { get; set; }
    }
}
