/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RedirectPaymentProduct863SpecificInput
    {
        /// <summary>
        /// The type of integration with WeChat. Possible values: 
        /// <list type="bullet">
        ///   <item><description>desktopQRCode - used on desktops, the customer opens the WeChat app by scanning a QR code.</description></item>
        ///   <item><description>urlIntent - used in mobile apps or on mobile web pages, the customer opens the WeChat app using a URL intent.</description></item>
        ///   <item><description>nativeInApp - used in mobile apps that use the WeChat Pay SDK.</description></item>
        ///   <item><description>javaScriptAPI - used for WeChat official accounts. Requires the QQ browser to function.</description></item>
        ///   <item><description>miniProgram - used for Mini Programs.</description></item>
        /// </list>
        /// </summary>
        public string IntegrationType { get; set; }

        /// <summary>
        /// An openId of a customer.
        /// </summary>
        public string OpenId { get; set; }
    }
}
