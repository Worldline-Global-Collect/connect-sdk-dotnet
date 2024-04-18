/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class AbstractThreeDSecure
    {
        public AmountOfMoney AuthenticationAmount { get; set; }

        public string AuthenticationFlow { get; set; }

        public string ChallengeCanvasSize { get; set; }

        public string ChallengeIndicator { get; set; }

        public string ExemptionRequest { get; set; }

        public ThreeDSecureData PriorThreeDSecureData { get; set; }

        public SdkDataInput SdkData { get; set; }

        public bool? SkipAuthentication { get; set; }

        public string TransactionRiskLevel { get; set; }
    }
}
