/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class LodgingRoom
    {
        /// <summary>
        /// Daily room rate exclusive of any taxes and fees
        /// <br />Note: The currencyCode is presumed to be identical to the order.amountOfMoney.currencyCode.
        /// </summary>
        public string DailyRoomRate { get; set; }

        /// <summary>
        /// Currency for Daily room rate. The code should be in 3 letter ISO format
        /// </summary>
        public string DailyRoomRateCurrencyCode { get; set; }

        /// <summary>
        /// Daily room tax
        /// <br />Note: The currencyCode is presumed to be identical to the order.amountOfMoney.currencyCode.
        /// </summary>
        public string DailyRoomTaxAmount { get; set; }

        /// <summary>
        /// Currency for Daily room tax. The code should be in 3 letter ISO format
        /// </summary>
        public string DailyRoomTaxAmountCurrencyCode { get; set; }

        /// <summary>
        /// Number of nights charged at the rate in the dailyRoomRate property
        /// </summary>
        public int? NumberOfNightsAtRoomRate { get; set; }

        /// <summary>
        /// Location of the room within the facility, e.g. Park or Garden etc.
        /// </summary>
        public string RoomLocation { get; set; }

        /// <summary>
        /// Room number
        /// </summary>
        public string RoomNumber { get; set; }

        /// <summary>
        /// Size of bed, e.g., king, queen, double.
        /// </summary>
        public string TypeOfBed { get; set; }

        /// <summary>
        /// Describes the type of room, e.g., standard, deluxe, suite.
        /// </summary>
        public string TypeOfRoom { get; set; }
    }
}
