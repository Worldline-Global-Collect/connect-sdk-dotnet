/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using Worldline.Connect.Sdk.Communication;

namespace Worldline.Connect.Sdk.V1.Merchant.Productgroups
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://apireference.connect.worldline-solutions.com/s2sapi/v1/en_US/dotnet/productgroups/find.html">Get payment product groups</a>
    /// </summary>
    public class FindProductgroupsParams : AbstractParamRequest
    {
        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the transaction
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Three-letter ISO currency code representing the currency for the amount
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Locale used in the GUI towards the consumer. Please make sure that a language pack is configured for the locale you are submitting. If you submit a locale that is not set up on your account, we will use the default language pack for your account. You can easily upload additional language packs and set the default language pack in the Configuration Center.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Amount of the transaction in cents and always having 2 decimals
        /// </summary>
        public long? Amount { get; set; }

        /// <summary>
        /// This allows you to filter groups based on their support for recurring, where a group supports recurring if it has at least one payment product that supports recurring 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// This allows you to filter payment products based on their support for installments or not 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>If this is omitted all payment products are returned.
        /// </summary>
        public bool? IsInstallments { get; set; }

        /// <summary>
        /// Allows you to hide elements from the response, reducing the amount of data that needs to be returned to your client. Possible options are: 
        /// <list type="bullet">
        ///   <item><description>fields - Don't return any data on fields of the payment product</description></item>
        ///   <item><description>accountsOnFile - Don't return any accounts on file data</description></item>
        ///   <item><description>translations - Don't return any label texts associated with the payment products</description></item>
        /// </list>
        /// </summary>
        public IList<string> Hide { get; set; }

        public void AddHide(string value)
        {
            var hide = Hide;
            if (hide == null)
            {
                hide = new List<string>();
                Hide = hide;
            }
            hide.Add(value);
        }

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            var result = new List<RequestParam>();
            if (CountryCode != null)
            {
                result.Add(new RequestParam("countryCode", CountryCode));
            }
            if (CurrencyCode != null)
            {
                result.Add(new RequestParam("currencyCode", CurrencyCode));
            }
            if (Locale != null)
            {
                result.Add(new RequestParam("locale", Locale));
            }
            if (Amount != null)
            {
                result.Add(new RequestParam("amount", Amount.ToString()));
            }
            if (IsRecurring != null)
            {
                result.Add(new RequestParam("isRecurring", IsRecurring.ToString().ToLower()));
            }
            if (IsInstallments != null)
            {
                result.Add(new RequestParam("isInstallments", IsInstallments.ToString().ToLower()));
            }
            if (Hide != null)
            {
                foreach (var hideElement in Hide)
                {
                    if (hideElement != null)
                    {
                        result.Add(new RequestParam("hide", hideElement));
                    }
                }
            }
            return result;
        }
    }
}
