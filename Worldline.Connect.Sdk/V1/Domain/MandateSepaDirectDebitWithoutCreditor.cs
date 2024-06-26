/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class MandateSepaDirectDebitWithoutCreditor
    {
        /// <summary>
        /// Object containing Account holder and IBAN information
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; }

        /// <summary>
        /// Identifies the contract between customer and merchant
        /// </summary>
        public string CustomerContractIdentifier { get; set; }

        /// <summary>
        /// Object containing information on the debtor
        /// </summary>
        public Debtor Debtor { get; set; }

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// Object containing the details of the mandate approval
        /// </summary>
        public MandateApproval MandateApproval { get; set; }

        /// <summary>
        /// Indicates whether a pre-notification should be sent to the customer.
        /// <br />
        /// <list type="bullet">
        ///   <item><description>do-not-send - Do not send a pre-notification</description></item>
        ///   <item><description>send-on-first-collection - Send a pre-notification</description></item>
        /// </list>
        /// </summary>
        public string PreNotification { get; set; }
    }
}
