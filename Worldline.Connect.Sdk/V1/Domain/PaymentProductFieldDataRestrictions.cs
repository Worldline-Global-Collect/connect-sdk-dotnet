/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProductFieldDataRestrictions
    {
        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true - Indicates that this field is required</description></item>
        ///   <item><description>false - Indicates that this field is optional</description></item>
        /// </list>
        /// </summary>
        public bool? IsRequired { get; set; } = null;

        /// <summary>
        /// Object containing the details of the validations on the field
        /// </summary>
        public PaymentProductFieldValidators Validators { get; set; } = null;
    }
}
