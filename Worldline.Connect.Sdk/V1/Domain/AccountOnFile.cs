/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class AccountOnFile
    {
        /// <summary>
        /// Array containing the details of the stored token
        /// </summary>
        public IList<AccountOnFileAttribute> Attributes { get; set; }

        /// <summary>
        /// Object containing information for the client on how best to display this field
        /// </summary>
        public AccountOnFileDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// ID of the account on file record
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Payment product identifier
        /// <br />Please see 
        /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/paymentproducts.html">payment products</a> for a full overview of possible values.
        /// </summary>
        public int? PaymentProductId { get; set; }
    }
}
