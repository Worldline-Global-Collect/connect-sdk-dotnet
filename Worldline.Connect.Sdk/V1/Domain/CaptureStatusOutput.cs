/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using KeyValuePair = Worldline.Connect.Sdk.V1.Domain.KeyValuePair;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CaptureStatusOutput
    {
        /// <summary>
        /// Flag indicating if a capture can be refunded 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? IsRefundable { get; set; }

        /// <summary>
        /// Flag indicating whether a rejected capture may be retried by you without incurring a fee 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? IsRetriable { get; set; }

        /// <summary>
        /// This is the raw response returned by the acquirer. This property contains unprocessed data directly returned by the acquirer. It's recommended for data analysis only due to its dynamic nature, which may undergo future changes.
        /// </summary>
        public IList<KeyValuePair> ProviderRawOutput { get; set; }

        /// <summary>
        /// Numeric status code of the legacy API. It is returned to ease the migration from the legacy APIs to Worldline Connect. You should not write new business logic based on this property as it will be deprecated in a future version of the API. The value can also be found in the GlobalCollect Payment Console, in the Ogone BackOffice and in report files.
        /// </summary>
        public int? StatusCode { get; set; }

        /// <summary>
        /// Date and time of capture
        /// <br /> Format: YYYYMMDDHH24MISS
        /// </summary>
        public string StatusCodeChangeDateTime { get; set; }
    }
}
