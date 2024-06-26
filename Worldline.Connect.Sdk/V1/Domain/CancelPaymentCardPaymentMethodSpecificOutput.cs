/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CancelPaymentCardPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Result of the authorization reversal request 
        /// <p>Possible values are:</p>
        /// <list type="bullet">
        ///   <item><description>00 - Successful reversal</description></item>
        ///   <item><description>0, 8 or 11 - Reversal request submitted</description></item>
        ///   <item><description>5 or 55 - Reversal request declined or referred</description></item>
        ///   <item><description>empty or 98 - The provider did not provide a response</description></item>
        /// </list>
        /// </summary>
        public string VoidResponseId { get; set; }
    }
}
