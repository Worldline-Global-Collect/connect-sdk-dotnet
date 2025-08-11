using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Worldline.Connect.Sdk.Domain;
using Worldline.Connect.Sdk.Json;

namespace Worldline.Connect.Sdk.Communication
{
    /// <summary>
    /// Provides meta info about the server. Thread-safe.
    /// </summary>
    public class MetadataProvider
    {
        public MetadataProvider(MetadataProviderBuilder builder)
            : this(builder.Integrator, builder.ShoppingCartExtension, builder.AdditionalRequestHeaders)
        {

        }

        public MetadataProvider(string integrator) : this(integrator, null, null)
        {

        }

        public static void ValidateAdditionalRequestHeader(RequestHeader additionalRequestHeader)
        {
            if (ProhibitedHeaders.Contains(additionalRequestHeader.Name))
            {
                throw new ArgumentException("request header not allowed: " + additionalRequestHeader);
            }
        }

        /// <summary>
        /// Gets the server related headers containing the metadata to be associated with the request (if any).
        /// This will always contain at least an automatically generated header <c>X-GCS-ServerMetaInfo</c>.
        /// </summary>
        public IEnumerable<RequestHeader> ServerMetadataHeaders { get; }

        public static readonly IEnumerable<string> ProhibitedHeaders
            = new ReadOnlyCollection<string>(new List<string>
        {
            ServerMetaInfoHeader,
            "X-GCS-Idempotence-Key",
            "Date",
            "Content-Type",
            "Authorization"
        });

        private MetadataProvider(string integrator, ShoppingCartExtension shoppingCartExtension, IEnumerable<RequestHeader> additionalRequestHeaders)
        {
            if (integrator.IsBlank())
            {
                throw new ArgumentException("integrator is required");
            }
            ValidateAdditionalRequestHeaders(additionalRequestHeaders);

            var serverMetaInfo = new ServerMetaInfo
            {
                PlatformIdentifier = PlatformIdentifier,
                SdkIdentifier = SdkIdentifier,
                SdkCreator = "Worldline",
                Integrator = integrator,
                ShoppingCartExtension = shoppingCartExtension
            };

            var serverMetaInfoString = DefaultMarshaller.Instance.Marshal(serverMetaInfo);
            var serverMetaInfoHeader = new RequestHeader(ServerMetaInfoHeader, serverMetaInfoString.ToBase64String());

            ServerMetadataHeaders = new List<RequestHeader> { serverMetaInfoHeader }
                .Concat(additionalRequestHeaders ?? Enumerable.Empty<RequestHeader>());
        }

        internal class ServerMetaInfo
        {
            public string PlatformIdentifier { get; set; }

            public string SdkIdentifier { get; set; }

            public string SdkCreator { get; set; }

            public string Integrator { get; set; }

            public ShoppingCartExtension ShoppingCartExtension { get; set; }
        }

        internal string SdkIdentifier => "DotnetServerSDK/v" + SdkVersion;

        internal string PlatformIdentifier => new StringBuilder()
            .Append(Environment.OSVersion.Platform)
            .Append("/")
            .Append(Environment.OSVersion.Version)
            .Append(" .NET/")
            .Append(Environment.Version)
            .ToString();

        private const string SdkVersion = "4.6.0";

        private const string ServerMetaInfoHeader = "X-GCS-ServerMetaInfo";

        internal static void ValidateAdditionalRequestHeaders(IEnumerable<RequestHeader> additionalRequestHeaders)
        {
            if (additionalRequestHeaders != null)
            {
                foreach (var additionalRequestHeader in additionalRequestHeaders)
                {
                    ValidateAdditionalRequestHeader(additionalRequestHeader);
                }
            }
        }
    }
}
