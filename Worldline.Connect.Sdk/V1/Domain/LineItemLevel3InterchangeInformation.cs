/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class LineItemLevel3InterchangeInformation
    {
        /// <summary>
        /// Discount on the line item, with the last two digits are implied decimal places
        /// </summary>
        public long? DiscountAmount { get; set; }

        /// <summary>
        /// Total amount for the line item
        /// </summary>
        public long? LineAmountTotal { get; set; }

        /// <summary>
        /// Product or UPC Code, left justified
        /// <br />Note: Must not be all spaces or all zeros
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// The price of one unit of the product, the value should be zero or greater
        /// </summary>
        public long? ProductPrice { get; set; }

        /// <summary>
        /// Code used to classify items that are purchased
        /// <br />Note: Must not be all spaces or all zeros
        /// </summary>
        public string ProductType { get; set; }

        /// <summary>
        /// Quantity of the units being purchased, should be greater than zero
        /// <br />Note: Must not be all spaces or all zeros
        /// </summary>
        public long? Quantity { get; set; }

        /// <summary>
        /// Tax on the line item, with the last two digits are implied decimal places
        /// </summary>
        public long? TaxAmount { get; set; }

        /// <summary>
        /// Indicates the line item unit of measure; for example: each, kit, pair, gallon, month, etc.
        /// </summary>
        public string Unit { get; set; }
    }
}
