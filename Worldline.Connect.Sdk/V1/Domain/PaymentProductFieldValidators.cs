/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProductFieldValidators
    {
        /// <summary>
        /// Indicates the requiredness of the field based on the fiscalnumber for Boleto Bancario
        /// </summary>
        public BoletoBancarioRequirednessValidator BoletoBancarioRequiredness { get; set; }

        /// <summary>
        /// Indicates that the content should be validated against the rules for an email address
        /// </summary>
        public EmptyValidator EmailAddress { get; set; }

        /// <summary>
        /// Indicates that the content should be validated against the rules for an expiration date (it should be in the future)
        /// </summary>
        public EmptyValidator ExpirationDate { get; set; }

        /// <summary>
        /// Indicates that content should be one of the, in this object, listed items
        /// </summary>
        public FixedListValidator FixedList { get; set; }

        /// <summary>
        /// Indicates that the content of this (iban) field needs to validated against format checks and modulo check (as described in ISO 7064)
        /// </summary>
        public EmptyValidator Iban { get; set; }

        /// <summary>
        /// Indicates that the content needs to be validated against length criteria defined in this object
        /// </summary>
        public LengthValidator Length { get; set; }

        /// <summary>
        /// Indicates that the content needs to be validated using a LUHN check
        /// </summary>
        public EmptyValidator Luhn { get; set; }

        /// <summary>
        /// Indicates that the content needs to be validated against a, in this object, defined range
        /// </summary>
        public RangeValidator Range { get; set; }

        /// <summary>
        /// A string representing the regular expression to check
        /// </summary>
        public RegularExpressionValidator RegularExpression { get; set; }

        /// <summary>
        /// Indicates that the content needs to be validated as per the Chinese resident identity number format
        /// </summary>
        public EmptyValidator ResidentIdNumber { get; set; }

        /// <summary>
        /// Indicates that the content should be validated as such that the customer has accepted the field as if they were terms and conditions of a service
        /// </summary>
        public EmptyValidator TermsAndConditions { get; set; }
    }
}
