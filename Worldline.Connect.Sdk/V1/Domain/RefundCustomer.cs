/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RefundCustomer
    {
        /// <summary>
        /// Object containing address details
        /// </summary>
        public AddressPersonal Address { get; set; }

        /// <summary>
        /// Object containing company information
        /// </summary>
        public CompanyInformation CompanyInformation { get; set; }

        /// <summary>
        /// Object containing contact details like email address and phone number
        /// </summary>
        public ContactDetailsBase ContactDetails { get; set; }

        /// <summary>
        /// The fiscal registration number of the customer or the tax registration number of the company in case of a business customer. Please find below specifics per country: 
        /// <list type="bullet">
        ///   <item><description>Argentina - Consumer (DNI) with a length of 7 or 8 digits</description></item>
        ///   <item><description>Argentina - Company (CUIT) with a length of 11 digits</description></item>
        ///   <item><description>Brazil - Individual (CPF): 11 digits. May include dots and a hyphen; maximum length is 14 characters</description></item>
        ///   <item><description>Brazil - Company (CNPJ): 14 characters, numeric or alphanumeric. May include dots, a hyphen and a slash; maximum length is 18 characters</description></item>
        ///   <item><description>Brazil - Formatted CPF and CNPJ values are accepted and normalized before validation when customer.address.countryCode is BR. For other country codes, fiscal numbers are validated without Brazilian normalization. For alphanumeric CNPJ, check digits are validated after converting each character to a numeric value (ASCII code - 48)</description></item>
        ///   <item><description>Chile - Consumer (RUT) with a length of 9 digits</description></item>
        ///   <item><description>Colombia - Consumer (NIT) with a length of 8, 9 or 10 digits</description></item>
        ///   <item><description>Denmark - Consumer (CPR-nummer or personnummer) with a length of 10 digits</description></item>
        ///   <item><description>Dominican Republic - Consumer (RNC) with a length of 11 digits</description></item>
        ///   <item><description>Finland - Consumer (Finnish: henkil&#246;tunnus (abbreviated as HETU)) with a length of 11 characters</description></item>
        ///   <item><description>India - Consumer (PAN) with a length of 10 characters</description></item>
        ///   <item><description>Mexico - Consumer (RFC) with a length of 13 digits</description></item>
        ///   <item><description>Mexico - Company (RFC) with a length of 12 digits</description></item>
        ///   <item><description>Norway - Consumer (f&#248;dselsnummer) with a length of 11 digits</description></item>
        ///   <item><description>Peru - Consumer (RUC) with a length of 11 digits</description></item>
        ///   <item><description>Sweden - Consumer (personnummer) with a length of 10 or 12 digits</description></item>
        ///   <item><description>Uruguay - Consumer (CI) with a length of 8 digits</description></item>
        ///   <item><description>Uruguay - Consumer (NIE) with a length of 9 digits</description></item>
        ///   <item><description>Uruguay - Company (RUT) with a length of 12 digits</description></item>
        /// </list>
        /// </summary>
        public string FiscalNumber { get; set; }
    }
}
