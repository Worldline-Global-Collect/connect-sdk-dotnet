/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CreateHostedCheckoutRequest
    {
        /// <summary>
        /// Object containing the specific input details for bank transfer payments
        /// </summary>
        public BankTransferPaymentMethodSpecificInputBase BankTransferPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the specific input details for card payments
        /// </summary>
        public CardPaymentMethodSpecificInputBase CardPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the specific input details for cash payments
        /// </summary>
        public CashPaymentMethodSpecificInputBase CashPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the specific input details for eInvoice payments
        /// </summary>
        public EInvoicePaymentMethodSpecificInputBase EInvoicePaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing additional data that will be used to assess the risk of fraud
        /// </summary>
        public FraudFields FraudFields { get; set; }

        /// <summary>
        /// Object containing hosted checkout specific data
        /// </summary>
        public HostedCheckoutSpecificInput HostedCheckoutSpecificInput { get; set; }

        /// <summary>
        /// Object containing information on you, the merchant
        /// </summary>
        public Merchant Merchant { get; set; }

        /// <summary>
        /// Object containing reference data for Google Pay (paymentProductId 320) and Apple Pay (paymentProductID 302).
        /// </summary>
        public MobilePaymentMethodSpecificInputHostedCheckout MobilePaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Order object containing order related data
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Object containing the specific input details for payments that involve redirects to 3rd parties to complete, like iDeal and PayPal
        /// </summary>
        public RedirectPaymentMethodSpecificInputBase RedirectPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the specific input details for SEPA direct debit payments
        /// </summary>
        public SepaDirectDebitPaymentMethodSpecificInputBase SepaDirectDebitPaymentMethodSpecificInput { get; set; }
    }
}
