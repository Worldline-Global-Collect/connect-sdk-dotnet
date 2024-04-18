/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ShoppingCart
    {
        /// <summary>
        /// Determines the type of the amount.
        /// </summary>
        public IList<AmountBreakdown> AmountBreakdown { get; set; }

        /// <summary>
        /// Object containing information on purchased gift card(s)
        /// </summary>
        public GiftCardPurchase GiftCardPurchase { get; set; }

        /// <summary>
        /// The customer is pre-ordering one or more items
        /// </summary>
        public bool? IsPreOrder { get; set; }

        /// <summary>
        /// Shopping cart data
        /// </summary>
        public IList<LineItem> Items { get; set; }

        /// <summary>
        /// Date (YYYYMMDD) when the preordered item becomes available
        /// </summary>
        public string PreOrderItemAvailabilityDate { get; set; }

        /// <summary>
        /// Indicates whether the cardholder is reordering previously purchased item(s) 
        /// <p>true = the customer is re-ordering at least one of the items again</p>
        /// <p>false = this is the first time the customer is ordering these items</p>
        /// </summary>
        public bool? ReOrderIndicator { get; set; }
    }
}
