/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class BankAccountBbanRefund : BankAccountBban
    {
        /// <summary>
        /// City of the bank to refund to
        /// </summary>
        public string BankCity { get; set; }

        /// <summary>
        /// Every Russian has three names: a first name, a patronymic, and a surname. The second name is a patronymic. Russian patronymic is a name derived from the father's first name by adding -&#1086;&#1074;&#1080;&#1095;/-&#1077;&#1074;&#1080;&#1095; (son of) for male, or -&#1086;&#1074;&#1085;&#1072;/-&#1077;&#1074;&#1085;&#1072; (daughter of) for females.
        /// </summary>
        public string PatronymicName { get; set; }

        /// <summary>
        /// The BIC is the Business Identifier Code, also known as SWIFT or Bank Identifier code. It is a code with an internationally agreed format to Identify a specific bank. The BIC contains 8 or 11 positions: the first 4 contain the bank code, followed by the country code and location code.
        /// </summary>
        public string SwiftCode { get; set; }
    }
}
