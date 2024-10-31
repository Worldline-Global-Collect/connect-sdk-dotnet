/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CompanyInformation
    {
        /// <summary>
        /// The date of incorporation is the specific date when the company was registered with the relevant authority.
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string DateOfIncorporation { get; set; }

        /// <summary>
        /// Name of company, as a customer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Local VAT number of the company
        /// </summary>
        public string VatNumber { get; set; }
    }
}
