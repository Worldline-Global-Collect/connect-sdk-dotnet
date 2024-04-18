/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ShippingRiskAssessment
    {
        /// <summary>
        /// Object containing address information
        /// </summary>
        public AddressPersonal Address { get; set; }

        /// <summary>
        /// Comments included during shipping
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Shipment tracking number
        /// </summary>
        public string TrackingNumber { get; set; }
    }
}
