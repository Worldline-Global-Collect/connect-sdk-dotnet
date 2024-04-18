/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProduct302SpecificData
    {
        /// <summary>
        /// The networks that can be used in the current payment context. The strings that represent the networks in the array are identical to the strings that Apple uses in their 
        /// <a href="https://developer.apple.com/reference/passkit/pkpaymentnetwork" target="_blank">documentation</a>. For instance: "Visa".
        /// </summary>
        public IList<string> Networks { get; set; }
    }
}
