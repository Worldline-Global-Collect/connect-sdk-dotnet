using NUnit.Framework;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Domain;

namespace Worldline.Connect.Sdk.It
{
    public class RiskAssessmentsTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for risk assessments service.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            var bankAccountBban = new BankAccountBban
            {
                CountryCode = "DE",
                AccountNumber = "0532013000",
                BankCode = "37040044"
            };

            var amountOfMoney = new AmountOfMoney
            {
                Amount = 100L,
                CurrencyCode = "EUR"
            };

            var customer = new CustomerRiskAssessment
            {
                Locale = "en_GB"
            };

            var order = new OrderRiskAssessment
            {
                AmountOfMoney = amountOfMoney,
                Customer = customer
            };

            var body = new RiskAssessmentBankAccount
            {
                BankAccountBban = bankAccountBban,
                Order = order
            };

            using (var client = GetClient())
            {
                var riskAssessmentResponse = await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Riskassessments
                    .Bankaccounts(body);
                Assert.That(riskAssessmentResponse.Results, Is.Not.Empty);
            }
        }
    }
}
