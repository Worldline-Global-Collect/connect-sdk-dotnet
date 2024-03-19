using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Worldline.Connect.Sdk.Communication;

namespace Worldline.Connect.Sdk.Authentication
{
    /// <summary>
    /// <see cref="IAuthenticator"/> implementation using v1HMAC signatures.
    /// </summary>
    public class V1HMACAuthenticator : IAuthenticator
    {
        /// <param name="apiKeyId">An identifier for the secret API key. The apiKeyId can be retrieved from the Configuration Center.
        ///        This identifier is visible in the HTTP request and is also used to identify the correct account.</param>
        /// <param name="secretApiKey">A shared secret. The shared secret can be retrieved from the Configuration Center.
        ///        An apiKeyId and secretApiKey always go hand-in-hand, the difference is that secretApiKey is never visible in the HTTP request.
        ///        This secret is used as input for the HMAC algorithm.</param>
        public V1HMACAuthenticator(string apiKeyId, string secretApiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKeyId))
            {
                throw new ArgumentException("apiKeyId is required");
            }
            if (string.IsNullOrWhiteSpace(secretApiKey))
            {
                throw new ArgumentException("secretApiKey is required");
            }
            _apiKeyId = apiKeyId;
            _secretApiKey = secretApiKey;

        }

        #region IAuthenticator Implementation
        public Task<string> GetAuthorization(HttpMethod httpMethod, Uri resourceUri, IEnumerable<IRequestHeader> requestHeaders)
        {
            if (httpMethod == null)
            {
                throw new ArgumentException("httpMethod is required");
            }
            if (resourceUri == null)
            {
                throw new ArgumentException("resourceUri is required");
            }
            var dataToSign = ToDataToSign(httpMethod, resourceUri, requestHeaders);
            return Task.FromResult("GCS v1HMAC:" + _apiKeyId + ":" + SignData(dataToSign));

        }
        #endregion

        internal static string ToDataToSign(HttpMethod httpMethod, Uri resourceUri, IEnumerable<IRequestHeader> requestHeaders)
        {
            var xgcsHttpHeaders = new List<IRequestHeader>();
            var contentType = "";
            var date = "";
            if (requestHeaders != null)
            {
                foreach (var header in requestHeaders)
                {
                    if (header.Name.Equals("content-type",StringComparison.OrdinalIgnoreCase))
                    {
                        contentType = header.Value;
                    }
                    else if (header.Name.Equals("date", StringComparison.OrdinalIgnoreCase))
                    {
                        date = header.Value;
                    }
                    else if (header.Name.StartsWith("x-gcs", StringComparison.OrdinalIgnoreCase))
                    {
                        xgcsHttpHeaders.Add(new RequestHeader(header.Name.ToLower(), ToCanonicalizeHeaderValue(header.Value)));
                    }
                }
            }
            xgcsHttpHeaders.Sort((x, y) => string.Compare(x.Name, y.Name, StringComparison.Ordinal));
            var sb = new StringBuilder();
            sb.AppendLLine(httpMethod.Method.ToUpperInvariant());
            sb.AppendLLine(contentType ?? "");
            sb.AppendLLine(date);
            foreach (var a in xgcsHttpHeaders.Select(arg => arg.Name + ":" + arg.Value))
            {
                sb.AppendLLine(a);
            }
            sb.AppendLLine(CanonicalizedResource(resourceUri));
            return sb.ToString();
        }

        internal string SignData(string theString)
        {
            var mac = new HMACSHA256(StringUtils.Encoding.GetBytes(_secretApiKey));
            mac.Initialize();
            var unencodedResult = mac.ComputeHash(StringUtils.Encoding.GetBytes(theString));
            var retVal = Convert.ToBase64String(unencodedResult);
            return retVal;
        }

        internal static string ToCanonicalizeHeaderValue(string originalValue)
        {
            const string pattern = "\r?\n[\\s-[\r\n]]*";
            var newString = new Regex(pattern, RegexOptions.Multiline | RegexOptions.CultureInvariant).Replace(originalValue, " ").Trim();
            return newString;
        }

        private readonly string _apiKeyId;

        private readonly string _secretApiKey;

        private static string CanonicalizedResource(Uri uri)
        {
            var sb = new StringBuilder();
            sb.Append(Uri.EscapeUriString(uri.LocalPath));
            if (!string.IsNullOrEmpty(uri.Query))
            {
                sb.Append(Uri.UnescapeDataString(uri.Query));
            }
            return sb.ToString();
        }
    }
}
