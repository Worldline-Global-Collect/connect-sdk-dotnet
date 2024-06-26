/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CashPaymentMethodSpecificInput : AbstractCashPaymentMethodSpecificInput
    {
        /// <summary>
        /// Object that holds the specific data for Boleto Bancario in Brazil (payment product 1503)
        /// </summary>
        [Obsolete("No replacement")]
        public CashPaymentProduct1503SpecificInput PaymentProduct1503SpecificInput { get; set; }

        /// <summary>
        /// Object that holds the specific data for Konbini in Japan (payment product 1504)
        /// </summary>
        public CashPaymentProduct1504SpecificInput PaymentProduct1504SpecificInput { get; set; }

        /// <summary>
        /// Object that holds the specific data for e-Pay (payment product 1521).
        /// </summary>
        public CashPaymentProduct1521SpecificInput PaymentProduct1521SpecificInput { get; set; }

        /// <summary>
        /// Object that holds the specific data for Tesco - Paysbuy Cash (payment product 1522).
        /// </summary>
        public CashPaymentProduct1522SpecificInput PaymentProduct1522SpecificInput { get; set; }

        /// <summary>
        /// Object that holds the specific data for ATM Transfers Indonesia(payment product 1523).
        /// </summary>
        public CashPaymentProduct1523SpecificInput PaymentProduct1523SpecificInput { get; set; }

        /// <summary>
        /// Object that holds the specific data for DragonPay (payment product 1524).
        /// </summary>
        public CashPaymentProduct1524SpecificInput PaymentProduct1524SpecificInput { get; set; }

        /// <summary>
        /// Object that holds the specific data for 7-11 MOLPay Cash (payment product 1526).
        /// </summary>
        public CashPaymentProduct1526SpecificInput PaymentProduct1526SpecificInput { get; set; }
    }
}
