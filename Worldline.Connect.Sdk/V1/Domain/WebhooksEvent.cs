/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class WebhooksEvent
    {
        public string ApiVersion { get; set; }

        public CaptureResponse Capture { get; set; }

        public string Created { get; set; }

        public DisputeResponse Dispute { get; set; }

        public string Id { get; set; }

        public string MerchantId { get; set; }

        public PaymentResponse Payment { get; set; }

        public PayoutResponse Payout { get; set; }

        public RefundResponse Refund { get; set; }

        public TokenResponse Token { get; set; }

        public string Type { get; set; }
    }
}
