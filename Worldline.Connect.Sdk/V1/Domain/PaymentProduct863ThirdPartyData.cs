/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProduct863ThirdPartyData
    {
        /// <summary>
        /// The appId to use in third party calls to WeChat.
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// The nonceStr to use in third party calls to WeChat
        /// </summary>
        public string NonceStr { get; set; }

        /// <summary>
        /// The packageSign to use in third party calls to WeChat
        /// </summary>
        public string PackageSign { get; set; }

        /// <summary>
        /// The paySign to use in third party calls to WeChat
        /// </summary>
        public string PaySign { get; set; }

        /// <summary>
        /// The prepayId to use in third party calls to WeChat.
        /// </summary>
        public string PrepayId { get; set; }

        /// <summary>
        /// The signType to use in third party calls to WeChat
        /// </summary>
        public string SignType { get; set; }

        /// <summary>
        /// The timeStamp to use in third party calls to WeChat
        /// </summary>
        public string TimeStamp { get; set; }
    }
}
