/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MandateResponse
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
        /// The unique identifier of the customer to which this mandate is applicable
        /// </summary>
        public string CustomerReference { get; set; }

        /// <summary>
        /// Specifieds whether the mandate is for one-off or recurring payments.
        /// </summary>
        public string RecurrenceType { get; set; }

        /// <summary>
        /// The status of the mandate. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>ACTIVE</description></item>
        ///   <item><description>EXPIRED</description></item>
        ///   <item><description>CREATED</description></item>
        ///   <item><description>REVOKED</description></item>
        ///   <item><description>WAITING_FOR_REFERENCE</description></item>
        ///   <item><description>BLOCKED</description></item>
        ///   <item><description>USED</description></item>
        /// </list>
        /// <br />
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The unique identifier of the mandate
        /// </summary>
        public string UniqueMandateReference { get; set; }
    }
}
