/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class SessionRequest
    {
        /// <summary>
        /// Restrict the payment products available for payment completion by restricting to and excluding certain payment products and payment product groups.
        /// </summary>
        public PaymentProductFiltersClientSession PaymentProductFilters { get; set; }

        /// <summary>
        /// List of previously stored tokens linked to the customer that wants to checkout.
        /// </summary>
        public IList<string> Tokens { get; set; }
    }
}
