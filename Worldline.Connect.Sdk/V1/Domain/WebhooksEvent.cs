/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class WebhooksEvent
    {
        public string ApiVersion { get; set; } = null;

        public string Created { get; set; } = null;

        public DisputeResponse Dispute { get; set; } = null;

        public string Id { get; set; } = null;

        public string MerchantId { get; set; } = null;

        public PaymentResponse Payment { get; set; } = null;

        public PayoutResponse Payout { get; set; } = null;

        public RefundResponse Refund { get; set; } = null;

        public TokenResponse Token { get; set; } = null;

        public string Type { get; set; } = null;
    }
}
