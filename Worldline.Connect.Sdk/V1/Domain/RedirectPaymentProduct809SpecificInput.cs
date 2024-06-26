/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RedirectPaymentProduct809SpecificInput
    {
        /// <summary>
        /// This sets the maximum amount of minutes a customer has to complete the payment at the bank. After this period has expired it is impossible for the customer to make a payment and in case no payment has been made the transaction will be marked as unsuccessful and expired by the bank. Setting the expirationPeriod is convenient if you want to maximise the time a customer has to complete the payment. Please note that it is normal for a customer to take up to 5 minutes to complete a payment. Setting this value below 10 minutes is not advised. 
        /// <br />You can set this value in minutes with a maximum value of 60 minutes. If no input is provided the default value of 60 is used for the transaction.
        /// </summary>
        [Obsolete("Use RedirectPaymentMethodSpecificInput.expirationPeriod instead")]
        public string ExpirationPeriod { get; set; }

        /// <summary>
        /// ID of the issuing bank of the customer. A list of available issuerIDs can be obtained by using the retrieve payment product directory API.
        /// </summary>
        public string IssuerId { get; set; }
    }
}
