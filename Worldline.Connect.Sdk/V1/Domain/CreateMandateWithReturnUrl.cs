/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CreateMandateWithReturnUrl : CreateMandateBase
    {
        /// <summary>
        /// Return URL to use if the mandate signing requires redirection.
        /// <br />Note: The provided URL should be absolute and contain the https:// protocol. IP addresses are not supported, neither localhost. For use on mobile devices a custom protocol can be used in the form of 
        /// <i>protocol</i>://. This protocol must be registered on the device first.
        /// <br />URLs without a protocol will be rejected.
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}
