/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class ValueMappingElement
    {
        /// <summary>
        /// List of extra data of the value.
        /// </summary>
        public IList<PaymentProductFieldDisplayElement> DisplayElements { get; set; } = null;

        /// <summary>
        /// Key name
        /// </summary>
        [Obsolete("Use displayElements instead with ID 'displayName'")]
        public string DisplayName { get; set; } = null;

        /// <summary>
        /// Value corresponding to the key
        /// </summary>
        public string Value { get; set; } = null;
    }
}
