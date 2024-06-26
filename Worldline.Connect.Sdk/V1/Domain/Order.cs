/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class Order
    {
        /// <summary>
        /// Object containing additional input on the order
        /// </summary>
        public AdditionalOrderInput AdditionalInput { get; set; }

        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Object containing the details of the customer
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Shopping cart data
        /// </summary>
        [Obsolete("Use shoppingCart.items instead")]
        public IList<LineItem> Items { get; set; }

        /// <summary>
        /// Object that holds all reference properties that are linked to this transaction
        /// </summary>
        public OrderReferences References { get; set; }

        /// <summary>
        /// Object containing seller details
        /// </summary>
        [Obsolete("Use Merchant.seller instead")]
        public Seller Seller { get; set; }

        /// <summary>
        /// Object containing information regarding shipping / delivery
        /// </summary>
        public Shipping Shipping { get; set; }

        /// <summary>
        /// Shopping cart data, including items and specific amounts.
        /// </summary>
        public ShoppingCart ShoppingCart { get; set; }
    }
}
