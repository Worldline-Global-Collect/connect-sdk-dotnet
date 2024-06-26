/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CreateMandateBase
    {
        /// <summary>
        /// An alias for the mandate. This can be used to visually represent the mandate.
        /// <br />Do not include any unobfuscated sensitive data in the alias.
        /// <br />Default value if not provided is the obfuscated IBAN of the customer.
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Customer object containing customer specific inputs
        /// </summary>
        public MandateCustomer Customer { get; set; }

        /// <summary>
        /// The unique identifier of a customer
        /// </summary>
        public string CustomerReference { get; set; }

        /// <summary>
        /// The language code of the customer, one of de, en, es, fr, it, nl, si, sk, sv.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Specifies whether the mandate is for one-off or recurring payments. Possible values are:
        /// <br />
        /// <list type="bullet">
        ///   <item><description>UNIQUE</description></item>
        ///   <item><description>RECURRING</description></item>
        /// </list>
        /// </summary>
        public string RecurrenceType { get; set; }

        /// <summary>
        /// Specifies whether the mandate is unsigned or singed by SMS. Possible values are:
        /// <br />
        /// <list type="bullet">
        ///   <item><description>UNSIGNED</description></item>
        ///   <item><description>SMS</description></item>
        /// </list>
        /// </summary>
        public string SignatureType { get; set; }

        /// <summary>
        /// The unique identifier of the mandate. If you do not provide one, we will generate one for you.
        /// </summary>
        public string UniqueMandateReference { get; set; }
    }
}
