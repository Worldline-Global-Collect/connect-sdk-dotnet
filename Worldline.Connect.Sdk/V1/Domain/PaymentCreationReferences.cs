/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentCreationReferences
    {
        /// <summary>
        /// The additional reference identifier for this transaction. Data in this property will also be returned in our report files, allowing you to reconcile them.
        /// </summary>
        public string AdditionalReference { get; set; }

        /// <summary>
        /// The external reference identifier for this transaction. Data in this property will also be returned in our report files, allowing you to reconcile them.
        /// </summary>
        public string ExternalReference { get; set; }
    }
}
