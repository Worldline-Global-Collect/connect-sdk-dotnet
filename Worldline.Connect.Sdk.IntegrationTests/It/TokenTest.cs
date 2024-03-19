using NUnit.Framework;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.V1.Domain;
using Worldline.Connect.Sdk.V1.Merchant.Tokens;

namespace Worldline.Connect.Sdk.It
{
    public class TokenTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for token calls.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            var billingAddress = new Address
            {
                CountryCode = "NL"
            };

            var customer = new CustomerToken
            {
                BillingAddress = billingAddress
            };

            var cardWithoutCvv = new CardWithoutCvv
            {
                CardholderName = "Jan",
                IssueNumber = "12",
                CardNumber = "4567350000427977",
                ExpiryDate = "1225"
            };

            var mandate = new TokenCardData
            {
                CardWithoutCvv = cardWithoutCvv
            };

            var card = new TokenCard
            {
                Customer = customer,
                Data = mandate
            };

            var createTokenRequest = new CreateTokenRequest
            {
                PaymentProductId = 1,
                Card = card
            };

            using (var client = GetClient())
            {
                var createTokenResponse = await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Tokens
                    .Create(createTokenRequest);

                Assert.NotNull(createTokenResponse.Token);

                var deleteTokenRequest = new DeleteTokenParams();

                await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Tokens
                    .Delete(createTokenResponse.Token, deleteTokenRequest);
            }
        }
    }
}
