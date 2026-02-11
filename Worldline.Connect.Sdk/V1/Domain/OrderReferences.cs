/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class OrderReferences
    {
        /// <summary>
        /// Descriptive text that is used towards to customer, either during an online checkout at a third party and/or on the statement of the customer. For card transactions this is usually referred to as a Soft Descriptor. The maximum allowed length varies per card acquirer: 
        /// <list type="bullet">
        ///   <item><description>AIB - 22 characters</description></item>
        ///   <item><description>American Express - 25 characters</description></item>
        ///   <item><description>Bambora - 22 characters</description></item>
        ///   <item><description>First Data APAC and AUS - 25 characters</description></item>
        ///   <item><description>Chase - not supported</description></item>
        ///   <item><description>INICIS (INIPAY) - 22-30 characters</description></item>
        ///   <item><description>Lidio - 30 characters</description></item>
        ///   <item><description>Worldline TAP UK - 22 characters</description></item>
        ///   <item><description>Worldline TAP EU - 22 characters</description></item>
        /// </list>Note that we advise you to use 22 characters as the max length as beyond this our experience is that issuers will start to truncate. We currently also only allow per API call overrides for AIB and Barclays
        /// <br />For alternative payment products the maximum allowed length varies per payment product: 
        /// <list type="bullet">
        ///   <item><description>402 e-Przelewy - 30 characters</description></item>
        ///   <item><description>404 INICIS - 80 characters</description></item>
        ///   <item><description>802 Nordea ePayment Finland - 234 characters</description></item>
        ///   <item><description>809 iDeal - 32 characters</description></item>
        ///   <item><description>840 PayPal - 127 characters</description></item>
        ///   <item><description>861 Alipay - 256 characters</description></item>
        ///   <item><description>863 WeChat Pay - 32 characters</description></item>
        ///   <item><description>900 Wero - 50 characters</description></item>
        ///   <item><description>1504 Konbini - 80 characters</description></item>
        /// </list>All other payment products don't support a descriptor.
        /// </summary>
        public string Descriptor { get; set; }

        /// <summary>
        /// Object containing additional invoice data
        /// </summary>
        public OrderInvoiceData InvoiceData { get; set; }

        /// <summary>
        /// Your order identifier
        /// <br />Note: This does not need to have a unique value for each transaction. This allows your to link multiple transactions to the same logical order in your system.
        /// </summary>
        public long? MerchantOrderId { get; set; }

        /// <summary>
        /// <div class="alert alert-info">Note that the maximum length of this field for transactions processed on the GlobalCollect platform is 30.</div>
        /// <div class="alert alert-info">Note that the maximum length of this field for transactions processed on the WL Online Payment Acceptance Platform platform is 50.</div>Your unique reference of the transaction that is also returned in our report files. This is almost always used for your reconciliation of our report files.
        /// </summary>
        public string MerchantReference { get; set; }

        /// <summary>
        /// Provides an additional means of reconciliation for Gateway merchants
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// Provides an additional means of reconciliation, this is the MerchantId used at the provider
        /// </summary>
        public string ProviderMerchantId { get; set; }
    }
}
