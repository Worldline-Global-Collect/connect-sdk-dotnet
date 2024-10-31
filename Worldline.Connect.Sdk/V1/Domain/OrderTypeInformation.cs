/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class OrderTypeInformation
    {
        /// <summary>
        /// Identifies the funding type being authenticated. Possible values are:
        /// <list type="bullet">
        ///   <item><description>personToPerson = When it is person to person funding (P2P)</description></item>
        ///   <item><description>agentCashOut = When fund is being paid out to final recipient in Cash by company's agent.</description></item>
        ///   <item><description>businessToConsumer = When fund is being transferred from business to consumer (B2C)</description></item>
        ///   <item><description>businessToBusiness = When fund is being transferred from business to business (B2B)</description></item>
        ///   <item><description>prefundingStagedWallet = When funding is being used to load the funds into the wallet account.</description></item>
        ///   <item><description>storedValueDigitalWallet = When funding is being used to load the funds into a stored value digital wallet.</description></item>
        ///   <item><description>fundingGiftCardForPersonalUse = When funding a gift card for personal use.</description></item>
        ///   <item><description>fundingGiftCardForSomeoneElse = When funding a gift card for someone else.</description></item>
        /// </list>
        /// </summary>
        public string FundingType { get; set; }

        /// <summary>
        /// Payment code to support account funding transactions. Possible values are:
        /// <br />
        /// <list type="bullet">
        ///   <item><description>accountManagement</description></item>
        ///   <item><description>paymentAllowance</description></item>
        ///   <item><description>settlementOfAnnuity</description></item>
        ///   <item><description>unemploymentDisabilityBenefit</description></item>
        ///   <item><description>businessExpenses</description></item>
        ///   <item><description>bonusPayment</description></item>
        ///   <item><description>busTransportRelatedBusiness</description></item>
        ///   <item><description>cashManagementTransfer</description></item>
        ///   <item><description>paymentOfCableTVBill</description></item>
        ///   <item><description>governmentInstituteIssued</description></item>
        ///   <item><description>creditCardPayment</description></item>
        ///   <item><description>creditCardBill</description></item>
        ///   <item><description>charity</description></item>
        ///   <item><description>collectionPayment</description></item>
        ///   <item><description>commercialPayment</description></item>
        ///   <item><description>commission</description></item>
        ///   <item><description>compensation</description></item>
        ///   <item><description>copyright</description></item>
        ///   <item><description>debitCardPayment</description></item>
        ///   <item><description>deposit</description></item>
        ///   <item><description>dividend</description></item>
        ///   <item><description>studyFees</description></item>
        ///   <item><description>electricityBill</description></item>
        ///   <item><description>energies</description></item>
        ///   <item><description>generalFees</description></item>
        ///   <item><description>ferry</description></item>
        ///   <item><description>foreignExchange</description></item>
        ///   <item><description>gasBill</description></item>
        ///   <item><description>unemployedCompensation</description></item>
        ///   <item><description>governmentPayment</description></item>
        ///   <item><description>healthInsurance</description></item>
        ///   <item><description>reimbursementCreditCard</description></item>
        ///   <item><description>reimbursementDebitCard</description></item>
        ///   <item><description>carInsurancePremium</description></item>
        ///   <item><description>insuranceClaim</description></item>
        ///   <item><description>installment</description></item>
        ///   <item><description>insurancePremium</description></item>
        ///   <item><description>investmentPayment</description></item>
        ///   <item><description>intraCompany</description></item>
        ///   <item><description>interest</description></item>
        ///   <item><description>incomeTax</description></item>
        ///   <item><description>investment</description></item>
        ///   <item><description>laborInsurance</description></item>
        ///   <item><description>licenseFree</description></item>
        ///   <item><description>lifeInsurance</description></item>
        ///   <item><description>loan</description></item>
        ///   <item><description>medicalServices</description></item>
        ///   <item><description>mobilePersonToBusiness</description></item>
        ///   <item><description>mobilePersonToPerson</description></item>
        ///   <item><description>mobileTopUp</description></item>
        ///   <item><description>notSpecified</description></item>
        ///   <item><description>other</description></item>
        ///   <item><description>anotherTelecomBill</description></item>
        ///   <item><description>payroll</description></item>
        ///   <item><description>pensionFundContribution</description></item>
        ///   <item><description>pensionPayment</description></item>
        ///   <item><description>telephoneBill</description></item>
        ///   <item><description>propertyInsurance</description></item>
        ///   <item><description>generalLease</description></item>
        ///   <item><description>rent</description></item>
        ///   <item><description>railwayPayment</description></item>
        ///   <item><description>royalties</description></item>
        ///   <item><description>salary</description></item>
        ///   <item><description>savingsPayment</description></item>
        ///   <item><description>securities</description></item>
        ///   <item><description>socialSecurity</description></item>
        ///   <item><description>study</description></item>
        ///   <item><description>subscription</description></item>
        ///   <item><description>supplierPayment</description></item>
        ///   <item><description>taxRefund</description></item>
        ///   <item><description>taxPayment</description></item>
        ///   <item><description>telecommunicationsBill</description></item>
        ///   <item><description>tradeServices</description></item>
        ///   <item><description>treasuryPayment</description></item>
        ///   <item><description>travelPayment</description></item>
        ///   <item><description>utilityBill</description></item>
        ///   <item><description>valueAddedTaxPayment</description></item>
        ///   <item><description>withHolding</description></item>
        ///   <item><description>waterBill</description></item>
        /// </list>.
        /// </summary>
        public string PaymentCode { get; set; }

        /// <summary>
        /// Possible values are:
        /// <list type="bullet">
        ///   <item><description>physical</description></item>
        ///   <item><description>digital</description></item>
        /// </list>
        /// </summary>
        public string PurchaseType { get; set; }

        /// <summary>
        /// Identifies the type of transaction being authenticated. Possible values are:
        /// <list type="bullet">
        ///   <item><description>purchase = The purpose of the transaction is to purchase goods or services (Default)</description></item>
        ///   <item><description>check-acceptance = The purpose of the transaction is to accept a 'check'/'cheque'</description></item>
        ///   <item><description>account-funding = The purpose of the transaction is to fund an account</description></item>
        ///   <item><description>quasi-cash = The purpose of the transaction is to buy a quasi cash type product that is representative of actual cash such as money orders, traveler's checks, foreign currency, lottery tickets or casino gaming chips</description></item>
        ///   <item><description>prepaid-activation-or-load = The purpose of the transaction is to activate or load a prepaid card</description></item>
        /// </list>
        /// </summary>
        public string TransactionType { get; set; }

        /// <summary>
        /// Possible values are:
        /// <list type="bullet">
        ///   <item><description>private</description></item>
        ///   <item><description>commercial</description></item>
        /// </list>
        /// </summary>
        public string UsageType { get; set; }
    }
}
