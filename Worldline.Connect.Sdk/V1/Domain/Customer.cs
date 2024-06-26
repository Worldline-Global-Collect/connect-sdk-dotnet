/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class Customer : CustomerBase
    {
        /// <summary>
        /// Object containing data related to the account the customer has with you
        /// </summary>
        public CustomerAccount Account { get; set; }

        /// <summary>
        /// Type of the customer account that is used to place this order. Can have one of the following values: 
        /// <list type="bullet">
        ///   <item><description>none - The account that was used to place the order with is a guest account or no account was used at all</description></item>
        ///   <item><description>created - The customer account was created during this transaction</description></item>
        ///   <item><description>existing - The customer account was an already existing account prior to this transaction</description></item>
        /// </list>
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Object containing billing address details
        /// </summary>
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Object containing contact details like email address and phone number
        /// </summary>
        public ContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Object containing information on the device and browser of the customer
        /// </summary>
        public CustomerDevice Device { get; set; }

        /// <summary>
        /// The fiscal registration number of the customer or the tax registration number of the company in case of a business customer. Please find below specifics per country: 
        /// <list type="bullet">
        ///   <item><description>Argentina - Consumer (DNI) with a length of 7 or 8 digits</description></item>
        ///   <item><description>Argentina - Company (CUIT) with a length of 11 digits</description></item>
        ///   <item><description>Brazil - Consumer (CPF) with a length of 11 digits</description></item>
        ///   <item><description>Brazil - Company (CNPJ) with a length of 14 digits</description></item>
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

        /// <summary>
        /// Indicates if the payer is a company or an individual 
        /// <list type="bullet">
        ///   <item><description>true = This is a company</description></item>
        ///   <item><description>false = This is an individual</description></item>
        /// </list>
        /// </summary>
        public bool? IsCompany { get; set; }

        /// <summary>
        /// Specifies if the customer has a history of online shopping with the merchant 
        /// <list type="bullet">
        ///   <item><description>true - The customer is a known returning customer</description></item>
        ///   <item><description>false - The customer is new/unknown customer</description></item>
        /// </list>
        /// </summary>
        public bool? IsPreviousCustomer { get; set; }

        /// <summary>
        /// The locale that the customer should be addressed in (for 3rd parties). Note that some 3rd party providers only support the languageCode part of the locale, in those cases we will only use part of the locale provided.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Object containing personal information like name, date of birth and gender.
        /// </summary>
        public PersonalInformation PersonalInformation { get; set; }

        /// <summary>
        /// Object containing shipping address details
        /// </summary>
        [Obsolete("Use Order.shipping.address instead")]
        public AddressPersonal ShippingAddress { get; set; }
    }
}
