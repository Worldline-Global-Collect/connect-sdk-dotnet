/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class InstallmentDisplayHints
    {
        /// <summary>
        /// Determines the order in which the installment options should be shown (sorted ascending). In countries like Turkey there are multiple loyalty programs that offer installments
        /// </summary>
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Name of the installment option
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Partial URL that you can reference for the image of this installment provider. You can use our server-side resize functionality by appending '?size={{width}}x{{height}}' to the full URL, where width and height are specified in pixels. The resized image will always keep its correct aspect ratio.
        /// </summary>
        public string Logo { get; set; }
    }
}
