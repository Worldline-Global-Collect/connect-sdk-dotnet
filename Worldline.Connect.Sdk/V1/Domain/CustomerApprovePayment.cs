/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CustomerApprovePayment
    {
        /// <summary>
        /// Type of the customer account that is used to place this order. Can have one of the following values: 
        /// <list type="bullet">
        ///   <item><description>none - The account that was used to place the order is a guest account or no account was used at all</description></item>
        ///   <item><description>created - The customer account was created during this transaction</description></item>
        ///   <item><description>existing - The customer account was an already existing account prior to this transaction</description></item>
        /// </list>
        /// </summary>
        public string AccountType { get; set; }
    }
}
