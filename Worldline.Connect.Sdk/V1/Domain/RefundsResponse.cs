/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RefundsResponse
    {
        /// <summary>
        /// The list of all refunds performed on the requested payment.
        /// </summary>
        public IList<RefundResult> Refunds { get; set; } = null;
    }
}
