/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class AccountFundingRecipient
    {
        /// <summary>
        /// Should be populated with the value of the corresponding accountNumberType of the recipient.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Defines the account number type of the recipient. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>cash = Mode of payment is cash to the recipient.</description></item>
        ///   <item><description>walletId = Digital wallet ID.</description></item>
        ///   <item><description>routingNumber = Routing Transit Number is a code used by financial institutions to identify other financial institutions.</description></item>
        ///   <item><description>iban = International Bank Account Number, is a standard international numbering system for identifying bank accounts.</description></item>
        ///   <item><description>bicNumber = Bank Identification Code is a number that is used to identify a specific bank.</description></item>
        ///   <item><description>giftCard = Gift card is a type of prepaid card that contains a specific amount of money that can be used at participating stores and marketplaces.</description></item>
        /// </list>
        /// </summary>
        public string AccountNumberType { get; set; }

        /// <summary>
        /// Object containing the address details of the recipient of an account funding transaction.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// The date of birth of the recipient
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Object containing the name details of the recipient of an account funding transaction.
        /// </summary>
        public AfrName Name { get; set; }

        /// <summary>
        /// Either partialPan or accountnumber is required for merchants that use Merchant Category Code (MCC) 6012 for transactions involving UK costumers.
        /// </summary>
        public string PartialPan { get; set; }
    }
}
