/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class Swift
    {
        /// <summary>
        /// The BIC is the Business Identifier Code, also known as SWIFT or Bank Identifier code. It is a code with an internationally agreed format to Identify a specific bank or even branch. The BIC contains 8 or 11 positions: the first 4 contain the bank code, followed by the country code and location code.
        /// </summary>
        public string Bic { get; set; }

        /// <summary>
        /// SWIFT category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Clearing House Interbank Payments System (CHIPS) UID
        /// <br />CHIPS is one half of the primary US network of large-value domestic and international payments.
        /// </summary>
        public string ChipsUID { get; set; }

        /// <summary>
        /// SWIFT extra information
        /// </summary>
        public string ExtraInfo { get; set; }

        /// <summary>
        /// Institution PO Box country
        /// </summary>
        public string PoBoxCountry { get; set; }

        /// <summary>
        /// Institution PO Box location
        /// </summary>
        public string PoBoxLocation { get; set; }

        /// <summary>
        /// Institution PO Box number
        /// </summary>
        public string PoBoxNumber { get; set; }

        /// <summary>
        /// Institution PO Box ZIP
        /// </summary>
        public string PoBoxZip { get; set; }

        /// <summary>
        /// Payment routing BIC
        /// </summary>
        public string RoutingBic { get; set; }

        /// <summary>
        /// SWIFT services
        /// </summary>
        public string Services { get; set; }
    }
}
