/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Riskassessments
{
    public static class RiskAssessmentCardsExample
    {
        public static async Task Example()
        {
#pragma warning disable 0168
            using (var client = GetClient())
            {
                var card = new Card();
                card.CardNumber = "4567350000427977";
                card.Cvv = "123";
                card.ExpiryDate = "1299";

                var flightLegs = new List<AirlineFlightLeg>();

                var flightLeg1 = new AirlineFlightLeg();
                flightLeg1.AirlineClass = "1";
                flightLeg1.ArrivalAirport = "AMS";
                flightLeg1.CarrierCode = "KL";
                flightLeg1.Date = "20150102";
                flightLeg1.DepartureTime = "17:59";
                flightLeg1.Fare = "fare";
                flightLeg1.FareBasis = "INTERNET";
                flightLeg1.FlightNumber = "791";
                flightLeg1.Number = 1;
                flightLeg1.OriginAirport = "BCN";
                flightLeg1.StopoverCode = "non-permitted";

                flightLegs.Add(flightLeg1);

                var flightLeg2 = new AirlineFlightLeg();
                flightLeg2.AirlineClass = "1";
                flightLeg2.ArrivalAirport = "BCN";
                flightLeg2.CarrierCode = "KL";
                flightLeg2.Date = "20150102";
                flightLeg2.DepartureTime = "23:59";
                flightLeg2.Fare = "fare";
                flightLeg2.FareBasis = "INTERNET";
                flightLeg2.FlightNumber = "792";
                flightLeg2.Number = 2;
                flightLeg2.OriginAirport = "AMS";
                flightLeg2.StopoverCode = "non-permitted";

                flightLegs.Add(flightLeg2);

                var airlineData = new AirlineData();
                airlineData.AgentNumericCode = "123321";
                airlineData.Code = "123";
                airlineData.FlightDate = "20150102";
                airlineData.FlightLegs = flightLegs;
                airlineData.InvoiceNumber = "123456";
                airlineData.IsETicket = true;
                airlineData.IsRestrictedTicket = true;
                airlineData.IsThirdParty = true;
                airlineData.IssueDate = "20150101";
                airlineData.MerchantCustomerId = "14";
                airlineData.Name = "Air France KLM";
                airlineData.PassengerName = "WECOYOTE";
                airlineData.PlaceOfIssue = "Utah";
                airlineData.Pnr = "4JTGKT";
                airlineData.PointOfSale = "IATA point of sale name";
                airlineData.PosCityCode = "AMS";
                airlineData.TicketDeliveryMethod = "e-ticket";
                airlineData.TicketNumber = "KLM20050000";

                var additionalInput = new AdditionalOrderInputAirlineData();
                additionalInput.AirlineData = airlineData;

                var amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 100L;
                amountOfMoney.CurrencyCode = "EUR";

                var billingAddress = new Address();
                billingAddress.CountryCode = "US";

                var customer = new CustomerRiskAssessment();
                customer.AccountType = "existing";
                customer.BillingAddress = billingAddress;
                customer.Locale = "en_US";

                var order = new OrderRiskAssessment();
                order.AdditionalInput = additionalInput;
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;

                var body = new RiskAssessmentCard();
                body.Card = card;
                body.Order = order;

                var response = await client.V1.WithNewMerchant("merchantId").Riskassessments.Cards(body);
            }
#pragma warning restore 0168
        }

        private static Client GetClient()
        {
            const string apiKeyId = "someKey";
            const string secretApiKey = "someSecret";

            var configuration = Factory.CreateConfiguration(apiKeyId, secretApiKey);
            return Factory.CreateClient(configuration);
        }
    }
}
