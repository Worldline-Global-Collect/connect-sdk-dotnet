using NUnit.Framework;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.V1.Merchant.Products;

namespace Worldline.Connect.Sdk.It
{
    public class MultiLineHeaderTest : IntegrationTest
    {
        [TestCase]
        public async Task Test()
        {
            var configuration = GetCommunicatorConfiguration();

            const string multiLineHeader = " some value  \r\n \n with  some \r\n  spaces ";
            var metadataProvider = new MetadataProviderBuilder("Worldline")
                    .WithAdditionalRequestHeader(new RequestHeader("X-GCS-MultiLineHeader", multiLineHeader))
                    .Build();

            var lParams = new DirectoryParams
            {
                CountryCode = "NL",
                CurrencyCode = "EUR"
            };

            var communicator = Factory.CreateCommunicatorBuilder(configuration)
                    .WithMetadataProvider(metadataProvider)
                    .Build();
            using (var client = Factory.CreateClient(communicator))
            {
                var response = await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Products
                    .Directory(809, lParams);

                Assert.That(response.Entries, Is.Not.Empty);

            }
        }

        [TestCase]
        public void SimpleTest()
        {
            var configuration = GetCommunicatorConfiguration();

            const string multiLineHeader = "some\nvalue";
            var metadataProvider = new MetadataProviderBuilder("Worldline")
                    .WithAdditionalRequestHeader(new RequestHeader("X-GCS-MultiLineHeader", multiLineHeader))
                    .Build();

            var communicator = Factory.CreateCommunicatorBuilder(configuration)
                    .WithMetadataProvider(metadataProvider)
                    .Build();
            using (var client = Factory.CreateClient(communicator))
            {
                Assert.DoesNotThrowAsync(async () => await client
                    .V1
                    .WithNewMerchant(GetMerchantId())
                    .Services
                    .Testconnection());
            }
        }
    }
}
