/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CapturePaymentShipping
    {
        /// <summary>
        /// Object containing address information
        /// </summary>
        public AddressPersonal Address { get; set; }

        /// <summary>
        /// Email address linked to the shipping
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The zip/postal code of the location from which the goods were shipped.
        /// </summary>
        public string ShippedFromZip { get; set; }

        /// <summary>
        /// Shipment tracking number
        /// </summary>
        public string TrackingNumber { get; set; }
    }
}
