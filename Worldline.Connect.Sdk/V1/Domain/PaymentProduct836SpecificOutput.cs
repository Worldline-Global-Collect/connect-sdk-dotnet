/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentProduct836SpecificOutput
    {
        /// <summary>
        /// Indicates if SofortBank could estabilish if the transaction could successfully be processed. 
        /// <list type="bullet">
        ///   <item><description>0 - You should wait for the transaction to be reported as paid before shipping any goods.</description></item>
        ///   <item><description>1 - You can ship the goods. In case the transaction is not reported as paid you can initiate a claims process with SofortBank.</description></item>
        /// </list>
        /// </summary>
        public string SecurityIndicator { get; set; }
    }
}
