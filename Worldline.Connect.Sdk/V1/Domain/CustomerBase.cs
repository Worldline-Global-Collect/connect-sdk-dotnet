/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CustomerBase
    {
        /// <summary>
        /// Object containing company information
        /// </summary>
        public CompanyInformation CompanyInformation { get; set; }

        /// <summary>
        /// Your identifier for the customer. It can be used as a search criteria in the GlobalCollect Payment Console and is also included in the GlobalCollect report files. It is used in the fraud-screening process for payments on the Ogone Payment Platform.
        /// </summary>
        public string MerchantCustomerId { get; set; }

        /// <summary>
        /// Local VAT number of the company
        /// </summary>
        [Obsolete("Use companyInformation.vatNumber instead")]
        public string VatNumber { get; set; }
    }
}
