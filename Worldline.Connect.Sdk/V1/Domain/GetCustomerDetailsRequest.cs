/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;
using KeyValuePair = Worldline.Connect.Sdk.V1.Domain.KeyValuePair;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class GetCustomerDetailsRequest
    {
        /// <summary>
        /// The code of the country where the customer should reside.
        /// </summary>
        public string CountryCode { get; set; } = null;

        /// <summary>
        /// A list of keys with a value used to retrieve the details of a customer. Depending on the country code, different keys are required. These can be determined with a getPaymentProduct call and using payment product properties with the property usedForLookup set to true.
        /// </summary>
        public IList<KeyValuePair> Values { get; set; } = null;
    }
}
