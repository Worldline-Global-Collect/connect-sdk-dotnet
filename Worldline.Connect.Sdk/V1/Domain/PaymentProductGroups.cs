/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProductGroups
    {
        /// <summary>
        /// Property paymentProductGroups
        /// <br />
        /// Array containing payment product groups and their characteristics
        /// </summary>
        [JsonProperty(PropertyName = "paymentProductGroups")]
        public IList<PaymentProductGroup> ListOfPaymentProductGroups { get; set; }
    }
}
