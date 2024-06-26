/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class OrderLineDetails
    {
        /// <summary>
        /// Discount on the line item, with the last two digits implied as decimal places
        /// </summary>
        public long? DiscountAmount { get; set; }

        /// <summary>
        /// The Google product category ID for the item.
        /// </summary>
        public long? GoogleProductCategoryId { get; set; }

        /// <summary>
        /// Total amount for the line item
        /// </summary>
        public long? LineAmountTotal { get; set; }

        /// <summary>
        /// The UNSPC commodity code of the item.
        /// </summary>
        public string NaicsCommodityCode { get; set; }

        /// <summary>
        /// The category of the product (i.e. home appliance). This property can be used for fraud screening on the Ogone Platform.
        /// </summary>
        public string ProductCategory { get; set; }

        /// <summary>
        /// Product or UPC Code, left justified
        /// <br />Note: Must not be all spaces or all zeros
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// The name of the product. The '+' character is not allowed in this property for transactions that are processed by TechProcess Payment Platform.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// The price of one unit of the product, the value should be zero or greater
        /// </summary>
        public long? ProductPrice { get; set; }

        /// <summary>
        /// Product SKU number
        /// </summary>
        public string ProductSku { get; set; }

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
        /// Tax on the line item, with the last two digits implied as decimal places
        /// </summary>
        public long? TaxAmount { get; set; }

        /// <summary>
        /// Indicates the line item unit of measure; for example: each, kit, pair, gallon, month, etc.
        /// </summary>
        public string Unit { get; set; }
    }
}
