/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProducts
    {
        /// <summary>
        /// Property paymentProducts
        /// <br />
        /// Array containing payment products and their characteristics
        /// </summary>
        [JsonProperty(PropertyName = "paymentProducts")]
        public IList<PaymentProduct> ListOfPaymentProducts { get; set; }
    }
}
