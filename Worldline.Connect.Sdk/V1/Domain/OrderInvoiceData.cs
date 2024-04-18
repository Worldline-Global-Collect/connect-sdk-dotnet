/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class OrderInvoiceData
    {
        /// <summary>
        /// Additional data for printed invoices
        /// </summary>
        public string AdditionalData { get; set; }

        /// <summary>
        /// Date and time on invoice
        /// <br />Format: YYYYMMDDHH24MISS
        /// </summary>
        public string InvoiceDate { get; set; }

        /// <summary>
        /// Your invoice number (on printed invoice) that is also returned in our report files
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Array of 3 text qualifiers, each with a max length of 10 characters
        /// </summary>
        public IList<string> TextQualifiers { get; set; }
    }
}
