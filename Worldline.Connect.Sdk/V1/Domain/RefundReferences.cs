/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RefundReferences
    {
        /// <summary>
        /// <p>Descriptive text that is used towards customer during refund. The maximum allowed length varies per payment product:</p>
        /// <list type="bullet">
        ///   <item><description>Wero - 50 characters</description></item>
        /// </list>
        /// </summary>
        public string Descriptor { get; set; }

        /// <summary>
        /// <div class="alert alert-info">Note that the maximum length of this field for transactions processed on the GlobalCollect platform is 30.</div>Your unique reference of the transaction that is also returned in our report files. This is almost always used for your reconciliation of our report files.
        /// </summary>
        public string MerchantReference { get; set; }
    }
}
