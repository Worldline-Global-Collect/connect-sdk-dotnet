/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RiskAssessmentBankAccount : RiskAssessment
    {
        /// <summary>
        /// Object containing account holder name and bank account information
        /// </summary>
        public BankAccountBban BankAccountBban { get; set; } = null;

        /// <summary>
        /// Object containing account holder name and IBAN information
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; } = null;
    }
}
