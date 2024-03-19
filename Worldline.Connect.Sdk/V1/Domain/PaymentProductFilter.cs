/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProductFilter
    {
        /// <summary>
        /// List containing all payment product groups that should either be restricted to in or excluded from the payment context. Currently, there is only one group, called 'cards'.
        /// </summary>
        public IList<string> Groups { get; set; } = null;

        /// <summary>
        /// List containing all payment product ids that should either be restricted to in or excluded from the payment context.
        /// </summary>
        public IList<int?> Products { get; set; } = null;
    }
}
