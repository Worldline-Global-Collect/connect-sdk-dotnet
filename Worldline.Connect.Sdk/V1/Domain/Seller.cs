/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class Seller
    {
        /// <summary>
        /// Object containing the seller address details
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// This property is specific to Visa Argentina. Channelcode according to Prisma. Please contact the acquirer to get the full list you need to use.
        /// </summary>
        public string ChannelCode { get; set; }

        /// <summary>
        /// Description of the seller
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Seller ID assigned by the Merchant Aggregator
        /// </summary>
        public string ExternalReferenceId { get; set; }

        /// <summary>
        /// The sellers geocode
        /// </summary>
        public string Geocode { get; set; }

        /// <summary>
        /// The sellers identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Invoice number of the payment
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Indicates if the retailer is considered foreign or domestic when compared to the location of the marketplace. Possible values: 
        /// <list type="bullet">
        ///   <item><description>true - The retailer is considered foreign because they are located in a different country than the marketplace. For marketplaces located in the European Economic Area (EEA) and UK (and Gibraltar), this includes transactions where the marketplace is within the EEA and UK (and Gibraltar), but the retailer is located outside of the EEA and UK (and Gibraltar)</description></item>
        ///   <item><description>false - The retailer is considered domestic because they are located in the same country as the marketplace. For marketplaces located in the European Economic Area (EEA) and UK (and Gibraltar), this includes transactions where the retailer is also located within the EEA and UK (and Gibraltar).</description></item>
        /// </list>
        /// </summary>
        public bool? IsForeignRetailer { get; set; }

        /// <summary>
        /// Merchant category code
        /// </summary>
        public string Mcc { get; set; }

        /// <summary>
        /// Name of the seller
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Main Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Seller type. Possible values: 
        /// <list type="bullet">
        ///   <item><description>passport</description></item>
        ///   <item><description>dni</description></item>
        ///   <item><description>arg-identity-card</description></item>
        ///   <item><description>civic-notebook</description></item>
        ///   <item><description>enrollment-book</description></item>
        ///   <item><description>cuil</description></item>
        ///   <item><description>cuit</description></item>
        ///   <item><description>general-register</description></item>
        ///   <item><description>election-title</description></item>
        ///   <item><description>cpf</description></item>
        ///   <item><description>cnpj</description></item>
        ///   <item><description>ssn</description></item>
        ///   <item><description>citizen-ship</description></item>
        ///   <item><description>col-identity-card</description></item>
        ///   <item><description>alien-registration</description></item>
        /// </list>
        /// </summary>
        public string Type { get; set; }
    }
}
