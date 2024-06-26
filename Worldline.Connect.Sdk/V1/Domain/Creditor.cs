/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class Creditor
    {
        /// <summary>
        /// Additional information about the creditor's address, like Suite II, Apartment 2a
        /// </summary>
        public string AdditionalAddressInfo { get; set; }

        /// <summary>
        /// City of the creditor address
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// House number of the creditor address
        /// </summary>
        public string HouseNumber { get; set; }

        /// <summary>
        /// Creditor IBAN number
        /// <br />The IBAN is the International Bank Account Number. It is an internationally agreed format for the bank account number and includes the ISO country code and two check digits.
        /// </summary>
        public string Iban { get; set; }

        /// <summary>
        /// Creditor identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the collecting creditor
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Creditor type of the legal reference of the collecting entity
        /// </summary>
        public string ReferenceParty { get; set; }

        /// <summary>
        /// Legal reference of the collecting creditor
        /// </summary>
        public string ReferencePartyId { get; set; }

        /// <summary>
        /// Street of the creditor address
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// ZIP code of the creditor address
        /// </summary>
        public string Zip { get; set; }
    }
}
