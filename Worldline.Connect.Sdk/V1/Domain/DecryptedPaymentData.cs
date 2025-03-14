/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class DecryptedPaymentData
    {
        /// <summary>
        /// The type of payment credential which the customer used. 
        /// <list type="bullet">
        ///   <item><description>For Google Pay, maps to the paymentMethodDetails.authMethod property in the encrypted payment data.</description></item>
        /// </list>.
        /// </summary>
        [Obsolete("Use decryptedPaymentData.paymentMethod instead")]
        public string AuthMethod { get; set; }

        /// <summary>
        /// The card holder's name on the card. Minimum length of 2, maximum length of 51 characters. 
        /// <list type="bullet">
        ///   <item><description>For Apple Pay, maps to the cardholderName property in the encrypted payment data.</description></item>
        ///   <item><description>For Google Pay this is not available in the encrypted payment data, and can be omitted.</description></item>
        /// </list>
        /// </summary>
        public string CardholderName { get; set; }

        /// <summary>
        /// The 3D secure online payment cryptogram. 
        /// <list type="bullet">
        ///   <item><description>For Apple Pay, maps to the paymentData.onlinePaymentCryptogram property in the encrypted payment data.</description></item>
        ///   <item><description>For Google Pay, maps to the paymentMethodDetails.cryptogram property in the encrypted payment data.</description></item>
        /// </list>Not allowed for Google Pay if the authMethod in the response of Google is PAN_ONLY.
        /// </summary>
        public string Cryptogram { get; set; }

        /// <summary>
        /// The device specific PAN. 
        /// <list type="bullet">
        ///   <item><description>For Apple Pay, maps to the applicationPrimaryAccountNumber property in the encrypted payment data.</description></item>
        ///   <item><description>For Google Pay, maps to the paymentMethodDetails.dpan property in the encrypted payment data.</description></item>
        /// </list>Not allowed for Google Pay if the authMethod in the response of Google is PAN_ONLY.
        /// </summary>
        public string Dpan { get; set; }

        /// <summary>
        /// The eci is Electronic Commerce Indicator. 
        /// <list type="bullet">
        ///   <item><description>For Apple Pay, maps to the paymentData.eciIndicator property in the encrypted payment data.</description></item>
        ///   <item><description>For Google Pay, maps to the paymentMethodDetails.eciIndicator property in the encrypted payment data.</description></item>
        /// </list>
        /// </summary>
        public int? Eci { get; set; }

        /// <summary>
        /// Expiry date of the card
        /// <br />Format: MMYY. 
        /// <list type="bullet">
        ///   <item><description>For Apple Pay, maps to the applicationExpirationDate property in the encrypted payment data. This property is formatted as YYMMDD, so this needs to be converted to get a correctly formatted expiry date.</description></item>
        ///   <item><description>For Google Pay, maps to the paymentMethodDetails.expirationMonth and paymentMethodDetails.expirationYear properties in the encrypted payment data. These need to be combined to get a correctly formatted expiry date.</description></item>
        /// </list>
        /// </summary>
        public string ExpiryDate { get; set; }

        /// <summary>
        /// The non-device specific complete credit/debit card number (also know as the PAN). 
        /// <list type="bullet">
        ///   <item><description>For Apple Pay this is not available in the encrypted payment data, and must be omitted.</description></item>
        ///   <item><description>For Google Pay, maps to the paymentMethodDetails.pan property in the encrypted payment data.</description></item>
        /// </list>Not allowed for Google Pay if the authMethod in the response of Google is CRYPTOGRAM_3DS.
        /// </summary>
        public string Pan { get; set; }

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>In case Google provides in the response as authMethod: CRYPTOGRAM_3DS send in as value of this property TOKENIZED_CARD.</description></item>
        ///   <item><description>In case Google provides in the response as authMethod: PAN_ONLY send in as value of this property CARD.</description></item>
        /// </list>For Apple Pay this is not available in the encrypted payment data, and must be omitted.
        /// </summary>
        public string PaymentMethod { get; set; }
    }
}
