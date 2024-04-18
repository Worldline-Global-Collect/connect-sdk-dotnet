/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class AdditionalOrderInput
    {
        /// <summary>
        /// Object containing specific data regarding the recipient of an account funding transaction
        /// </summary>
        public AccountFundingRecipient AccountFundingRecipient { get; set; }

        /// <summary>
        /// Object that holds airline specific data
        /// </summary>
        public AirlineData AirlineData { get; set; }

        /// <summary>
        /// Object containing data related to installments which can be used for card payments and only with some acquirers. In case you send in the details of this object, only the combination of card products and acquirers that do support installments will be shown on the MyCheckout hosted payment pages.
        /// </summary>
        public Installments Installments { get; set; }

        /// <summary>
        /// Object that holds Level3 summary data
        /// </summary>
        [Obsolete("Use Order.shoppingCart.amountBreakdown instead")]
        public Level3SummaryData Level3SummaryData { get; set; }

        /// <summary>
        /// Object containing specific data regarding the recipient of a loan in the UK
        /// </summary>
        [Obsolete("No replacement")]
        public LoanRecipient LoanRecipient { get; set; }

        /// <summary>
        /// Object that holds lodging specific data
        /// </summary>
        public LodgingData LodgingData { get; set; }

        /// <summary>
        /// The number of installments in which this transaction will be paid, which can be used for card payments. Only used with some acquirers. In case you send in the details of this object, only the combination of card products and acquirers that do support installments will be shown on the MyCheckout hosted payment pages.
        /// </summary>
        [Obsolete("Use installments.numberOfInstallments instead")]
        public long? NumberOfInstallments { get; set; }

        /// <summary>
        /// Date and time of order
        /// <br />Format: YYYYMMDDHH24MISS
        /// </summary>
        public string OrderDate { get; set; }

        /// <summary>
        /// Object that holds the purchase and usage type indicators
        /// </summary>
        public OrderTypeInformation TypeInformation { get; set; }
    }
}
