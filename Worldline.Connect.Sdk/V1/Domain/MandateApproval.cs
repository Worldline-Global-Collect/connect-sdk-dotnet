/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MandateApproval
    {
        /// <summary>
        /// The date when the mandate was signed
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string MandateSignatureDate { get; set; }

        /// <summary>
        /// The city where the mandate was signed
        /// </summary>
        public string MandateSignaturePlace { get; set; }

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true = Mandate is signed</description></item>
        ///   <item><description>false = Mandate is not signed</description></item>
        /// </list>
        /// </summary>
        public bool? MandateSigned { get; set; }
    }
}
