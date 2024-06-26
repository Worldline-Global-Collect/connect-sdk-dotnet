/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class Shipping
    {
        /// <summary>
        /// Object containing address information
        /// </summary>
        public AddressPersonal Address { get; set; }

        /// <summary>
        /// Indicates shipping method chosen for the transaction. Possible values: 
        /// <list type="bullet">
        ///   <item><description>same-as-billing = the shipping address is the same as the billing address</description></item>
        ///   <item><description>another-verified-address-on-file-with-merchant = the address used for shipping is another verified address of the customer that is on file with you</description></item>
        ///   <item><description>different-than-billing = shipping address is different from the billing address</description></item>
        ///   <item><description>ship-to-store = goods are shipped to a store (shipping address = store address)</description></item>
        ///   <item><description>digital-goods = electronic delivery of digital goods</description></item>
        ///   <item><description>travel-and-event-tickets-not-shipped = travel and/or event tickets that are not shipped</description></item>
        ///   <item><description>other = other means of delivery</description></item>
        /// </list>
        /// </summary>
        public string AddressIndicator { get; set; }

        /// <summary>
        /// Comments included during shipping
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Email address linked to the shipping
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Date (YYYYMMDD) when the shipping details for this transaction were first used.
        /// </summary>
        public string FirstUsageDate { get; set; }

        /// <summary>
        /// Indicator if this shipping address is used for the first time to ship an order 
        /// <p>true = the shipping details are used for the first time with this transaction</p>
        /// <p>false = the shipping details have been used for other transactions in the past</p>
        /// </summary>
        public bool? IsFirstUsage { get; set; }

        /// <summary>
        /// The zip/postal code of the location from which the goods were shipped.
        /// </summary>
        public string ShippedFromZip { get; set; }

        /// <summary>
        /// Shipment tracking number
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Indicates the merchandise delivery timeframe. Possible values: 
        /// <list type="bullet">
        ///   <item><description>electronic = For electronic delivery (services or digital goods)</description></item>
        ///   <item><description>same-day = For same day deliveries</description></item>
        ///   <item><description>overnight = For overnight deliveries</description></item>
        ///   <item><description>2-day-or-more = For two day or more delivery time for payments that are processed by the GlobalCollect platform</description></item>
        ///   <item><description>2-day-or-more = For two day or more delivery time for payments that are processed by the Ogone platform</description></item>
        ///   <item><description>priority = For prioritized deliveries for payments that are processed by the WL Online Payment Acceptance platform</description></item>
        ///   <item><description>ground = For deliveries via ground for payments that are processed by the WL Online Payment Acceptance platform</description></item>
        ///   <item><description>to-store = For deliveries to a store for payments that are processed by the WL Online Payment Acceptance platform</description></item>
        /// </list>
        /// </summary>
        public string Type { get; set; }
    }
}
