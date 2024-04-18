/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RiskAssessment
    {
        /// <summary>
        /// Object containing additional data that will be used to assess the risk of fraud
        /// </summary>
        public FraudFields FraudFields { get; set; }

        public MerchantRiskAssessment Merchant { get; set; }

        public OrderRiskAssessment Order { get; set; }

        /// <summary>
        /// Payment product identifier
        /// <br />Please see 
        /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/paymentproducts.html">payment products</a> for a full overview of possible values.
        /// </summary>
        public int? PaymentProductId { get; set; }
    }
}
