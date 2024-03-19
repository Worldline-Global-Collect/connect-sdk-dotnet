/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class LabelTemplateElement
    {
        /// <summary>
        /// Name of the attribute that is shown to the customer on selection pages or screens
        /// </summary>
        public string AttributeKey { get; set; } = null;

        /// <summary>
        /// Regular mask for the attributeKey
        /// <br />Note: The mask is optional as not every field has a mask
        /// </summary>
        public string Mask { get; set; } = null;
    }
}
