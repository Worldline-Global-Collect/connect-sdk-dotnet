/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CustomerDevice
    {
        /// <summary>
        /// The accept-header of the customer client from the HTTP Headers.
        /// </summary>
        public string AcceptHeader { get; set; }

        /// <summary>
        /// Object containing information regarding the browser of the customer
        /// </summary>
        public BrowserData BrowserData { get; set; }

        /// <summary>
        /// Degree of default form fill, with the following possible values: 
        /// <list type="bullet">
        ///   <item><description>automatically - All fields filled automatically</description></item>
        ///   <item><description>automatically-but-modified - All fields filled automatically, but some fields were modified manually</description></item>
        ///   <item><description>manually - All fields were entered manually</description></item>
        /// </list>
        /// </summary>
        public string DefaultFormFill { get; set; }

        /// <summary>
        /// One must set the deviceFingerprintTransactionId received by the response of the endpoint /{merchant}/products/{paymentProductId}/deviceFingerprint
        /// </summary>
        public string DeviceFingerprintTransactionId { get; set; }

        /// <summary>
        /// The IP address of the customer client from the HTTP Headers.
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Locale of the client device/browser. Returned in the browser from the navigator.language property. 
        /// <p>If you use the latest version of our JavaScript Client SDK, we will collect this data and include it in the encryptedCustomerInput property. We will then automatically populate this data if available.</p>
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Offset in minutes of timezone of the client versus the UTC. Value is returned by the JavaScript getTimezoneOffset() Method. 
        /// <p>If you use the latest version of our JavaScript Client SDK, we will collect this data and include it in the encryptedCustomerInput property. We will then automatically populate this data if available.</p>
        /// </summary>
        public string TimezoneOffsetUtcMinutes { get; set; }

        /// <summary>
        /// User-Agent of the client device/browser from the HTTP Headers. 
        /// <p>As a fall-back we will use the userAgent that might be included in the encryptedCustomerInput, but this is captured client side using JavaScript and might be different.</p>
        /// </summary>
        public string UserAgent { get; set; }
    }
}
