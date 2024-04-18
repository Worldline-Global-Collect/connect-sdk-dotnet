/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class AirlineFlightLeg
    {
        /// <summary>
        /// Reservation Booking Designator
        /// </summary>
        public string AirlineClass { get; set; }

        /// <summary>
        /// Arrival airport/city code
        /// </summary>
        public string ArrivalAirport { get; set; }

        /// <summary>
        /// The arrival time in the local time zone 
        /// <br />Format: HH:MM
        /// </summary>
        public string ArrivalTime { get; set; }

        /// <summary>
        /// IATA carrier code
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// Identifying number of a ticket issued to a passenger in conjunction with this ticket and that constitutes a single contract of carriage
        /// </summary>
        public string ConjunctionTicket { get; set; }

        /// <summary>
        /// The coupon number associated with this leg of the trip. A ticket can contain several legs of travel, and each leg of travel requires a separate coupon
        /// </summary>
        public string CouponNumber { get; set; }

        /// <summary>
        /// Date of the leg
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// The departure time in the local time at the departure airport
        /// <br />Format: HH:MM
        /// </summary>
        public string DepartureTime { get; set; }

        /// <summary>
        /// An endorsement can be an agency-added notation or a mandatory government required notation, such as value-added tax. A restriction is a limitation based on the type of fare, such as a ticket with a 3-day minimum stay
        /// </summary>
        public string EndorsementOrRestriction { get; set; }

        /// <summary>
        /// New ticket number that is issued when a ticket is exchanged
        /// </summary>
        public string ExchangeTicket { get; set; }

        /// <summary>
        /// Fare of this leg
        /// </summary>
        public string Fare { get; set; }

        /// <summary>
        /// Fare Basis/Ticket Designator
        /// </summary>
        public string FareBasis { get; set; }

        /// <summary>
        /// Fee for this leg of the trip
        /// </summary>
        public int? Fee { get; set; }

        /// <summary>
        /// The flight number assigned by the airline carrier with no leading spaces 
        /// <br />Should be a numeric string
        /// </summary>
        public string FlightNumber { get; set; }

        /// <summary>
        /// Sequence number of the flight leg
        /// </summary>
        public int? Number { get; set; }

        /// <summary>
        /// Origin airport/city code
        /// </summary>
        public string OriginAirport { get; set; }

        /// <summary>
        /// PassengerClass if this leg
        /// </summary>
        public string PassengerClass { get; set; }

        /// <summary>
        /// ServiceClass of this leg (this property is used for fraud screening on the Ogone Payment Platform). 
        /// <p>Possible values are:</p>
        /// <list type="bullet">
        ///   <item><description>economy</description></item>
        ///   <item><description>premium-economy</description></item>
        ///   <item><description>business</description></item>
        ///   <item><description>first</description></item>
        /// </list>
        /// </summary>
        [Obsolete("Use passengerClass instead")]
        public string ServiceClass { get; set; }

        /// <summary>
        /// Possible values are: 
        /// <list type="bullet">
        ///   <item><description>permitted = Stopover permitted</description></item>
        ///   <item><description>non-permitted = Stopover not permitted</description></item>
        /// </list>
        /// </summary>
        public string StopoverCode { get; set; }

        /// <summary>
        /// Taxes for this leg of the trip
        /// </summary>
        public int? Taxes { get; set; }
    }
}
