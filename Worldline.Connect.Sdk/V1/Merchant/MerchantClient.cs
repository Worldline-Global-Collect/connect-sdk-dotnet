/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.V1.Merchant.Captures;
using Worldline.Connect.Sdk.V1.Merchant.Disputes;
using Worldline.Connect.Sdk.V1.Merchant.Files;
using Worldline.Connect.Sdk.V1.Merchant.Hostedcheckouts;
using Worldline.Connect.Sdk.V1.Merchant.Hostedmandatemanagements;
using Worldline.Connect.Sdk.V1.Merchant.Installments;
using Worldline.Connect.Sdk.V1.Merchant.Mandates;
using Worldline.Connect.Sdk.V1.Merchant.Payments;
using Worldline.Connect.Sdk.V1.Merchant.Payouts;
using Worldline.Connect.Sdk.V1.Merchant.Productgroups;
using Worldline.Connect.Sdk.V1.Merchant.Products;
using Worldline.Connect.Sdk.V1.Merchant.Refunds;
using Worldline.Connect.Sdk.V1.Merchant.Riskassessments;
using Worldline.Connect.Sdk.V1.Merchant.Services;
using Worldline.Connect.Sdk.V1.Merchant.Sessions;
using Worldline.Connect.Sdk.V1.Merchant.Tokens;

namespace Worldline.Connect.Sdk.V1.Merchant
{
    /// <summary>
    /// Merchant client. Thread-safe.
    /// </summary>
    public class MerchantClient : ApiResource
    {
        public MerchantClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/hostedcheckouts
        /// </summary>
        /// <returns>HostedcheckoutsClient</returns>
        public HostedcheckoutsClient Hostedcheckouts => new HostedcheckoutsClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/hostedmandatemanagements
        /// </summary>
        /// <returns>HostedmandatemanagementsClient</returns>
        public HostedmandatemanagementsClient Hostedmandatemanagements => new HostedmandatemanagementsClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/payments
        /// </summary>
        /// <returns>PaymentsClient</returns>
        public PaymentsClient Payments => new PaymentsClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/captures
        /// </summary>
        /// <returns>CapturesClient</returns>
        public CapturesClient Captures => new CapturesClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/refunds
        /// </summary>
        /// <returns>RefundsClient</returns>
        public RefundsClient Refunds => new RefundsClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/disputes
        /// </summary>
        /// <returns>DisputesClient</returns>
        public DisputesClient Disputes => new DisputesClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/payouts
        /// </summary>
        /// <returns>PayoutsClient</returns>
        public PayoutsClient Payouts => new PayoutsClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/productgroups
        /// </summary>
        /// <returns>ProductgroupsClient</returns>
        public ProductgroupsClient Productgroups => new ProductgroupsClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/products
        /// </summary>
        /// <returns>ProductsClient</returns>
        public ProductsClient Products => new ProductsClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/riskassessments
        /// </summary>
        /// <returns>RiskassessmentsClient</returns>
        public RiskassessmentsClient Riskassessments => new RiskassessmentsClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/services
        /// </summary>
        /// <returns>ServicesClient</returns>
        public ServicesClient Services => new ServicesClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/tokens
        /// </summary>
        /// <returns>TokensClient</returns>
        public TokensClient Tokens => new TokensClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/mandates
        /// </summary>
        /// <returns>MandatesClient</returns>
        public MandatesClient Mandates => new MandatesClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/sessions
        /// </summary>
        /// <returns>SessionsClient</returns>
        public SessionsClient Sessions => new SessionsClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/installments
        /// </summary>
        /// <returns>InstallmentsClient</returns>
        public InstallmentsClient Installments => new InstallmentsClient(this, null);

        /// <summary>
        /// Resource /{merchantId}/files
        /// </summary>
        /// <returns>FilesClient</returns>
        public FilesClient Files => new FilesClient(this, null);
    }
}
