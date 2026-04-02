/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ClickToPayInput
    {
        /// <summary>
        /// The checkoutResponseSignature is a token (JWS) that signs the Checkout response returned by the SRC System after a successful Click to Pay payment. It is used to call the Click to Pay SRCI Server Payload API.
        /// </summary>
        public string CheckoutResponseSignature { get; set; }
    }
}
