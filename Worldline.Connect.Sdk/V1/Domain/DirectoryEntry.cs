/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class DirectoryEntry
    {
        /// <summary>
        /// Country name of the issuer, used to group issuers per country
        /// <br />Note: this is only filled if supported by the payment product.
        /// </summary>
        public IList<string> CountryNames { get; set; }

        /// <summary>
        /// Unique ID of the issuing bank of the customer
        /// </summary>
        public string IssuerId { get; set; }

        /// <summary>
        /// To be used to sort the issuers. 
        /// <list type="bullet">
        ///   <item><description>short - These issuers should be presented at the top of the list</description></item>
        ///   <item><description>long - These issuers should be presented after the issuers marked as short</description></item>
        /// </list>Note: this is only filled if supported by the payment product. Currently only iDeal (809) support this. Sorting within the groups should be done alphabetically.
        /// </summary>
        public string IssuerList { get; set; }

        /// <summary>
        /// Name of the issuing bank, as it should be presented to the customer
        /// </summary>
        public string IssuerName { get; set; }
    }
}
