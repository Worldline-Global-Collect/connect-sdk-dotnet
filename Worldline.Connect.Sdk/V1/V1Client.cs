/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.V1.Merchant;

namespace Worldline.Connect.Sdk.V1
{
    /// <summary>
    /// V1. Thread-safe.
    /// </summary>
    public class V1Client : ApiResource
    {
        public V1Client(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}
        /// </summary>
        /// <param name="merchantId">string</param>
        /// <returns>MerchantClient</returns>
        public MerchantClient WithNewMerchant(string merchantId)
        {
            IDictionary<string, string> subContext = new Dictionary<string, string>();
            subContext.Add("merchantId", merchantId);
            return new MerchantClient(this, subContext);
        }
    }
}
