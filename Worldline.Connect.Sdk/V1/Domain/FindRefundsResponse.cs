/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class FindRefundsResponse
    {
        /// <summary>
        /// The limit you used in the request.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// The offset you used in the request.
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// A list of refunds that matched your filter, starting at the given offset and limited to the given limit.
        /// </summary>
        public IList<RefundResult> Refunds { get; set; }

        /// <summary>
        /// The total number of refunds that matched your filter.
        /// </summary>
        public int? TotalCount { get; set; }
    }
}
