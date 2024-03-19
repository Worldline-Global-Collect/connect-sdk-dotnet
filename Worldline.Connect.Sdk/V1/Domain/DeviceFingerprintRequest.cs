/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class DeviceFingerprintRequest
    {
        /// <summary>
        /// You can supply a JavaScript function call that will be called after the device fingerprint data collecting using the provided JavaScript snippet is finished. This will then be added to the snippet that is returned in the property html.
        /// </summary>
        public string CollectorCallback { get; set; } = null;
    }
}
