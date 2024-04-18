/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProduct863SpecificData
    {
        /// <summary>
        /// The WeChat Pay integration types that can be used in the current payment context. Possible values: 
        /// <list type="bullet">
        ///   <item><description>desktopQRCode - used on desktops, the customer opens the WeChat app by scanning a QR code.</description></item>
        ///   <item><description>urlIntent - used in mobile apps or on mobile web pages, the customer opens the WeChat app using a URL intent.</description></item>
        ///   <item><description>nativeInApp - used in mobile apps that use the WeChat Pay SDK.</description></item>
        /// </list>
        /// </summary>
        public IList<string> IntegrationTypes { get; set; }
    }
}
