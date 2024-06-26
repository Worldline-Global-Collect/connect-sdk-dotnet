/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CustomerAccountRiskAssessment
    {
        /// <summary>
        /// Specifies if the customer (initially) had forgotten their password 
        /// <list type="bullet">
        ///   <item><description>true - The customer has forgotten their password</description></item>
        ///   <item><description>false - The customer has not forgotten their password</description></item>
        /// </list>
        /// </summary>
        public bool? HasForgottenPassword { get; set; }

        /// <summary>
        /// Specifies if the customer entered a password to gain access to an account registered with the you 
        /// <list type="bullet">
        ///   <item><description>true - The customer has used a password to gain access</description></item>
        ///   <item><description>false - The customer has not used a password to gain access</description></item>
        /// </list>
        /// </summary>
        public bool? HasPassword { get; set; }
    }
}
