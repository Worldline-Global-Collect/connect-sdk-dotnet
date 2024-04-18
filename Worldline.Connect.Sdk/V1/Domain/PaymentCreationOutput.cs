/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class PaymentCreationOutput : PaymentCreationReferences
    {
        /// <summary>
        /// Indicates whether the customer ticked the "Remember my details for future purchases" checkbox on the MyCheckout hosted payment pages
        /// </summary>
        public bool? IsCheckedRememberMe { get; set; }

        /// <summary>
        /// Indicates if a new token was created 
        /// <list type="bullet">
        ///   <item><description>true - A new token was created</description></item>
        ///   <item><description>false - A token with the same card number already exists and is returned. Please note that the existing token has not been updated. When you want to update other data then the card number, you need to update data stored in the token explicitly, as data is never updated during the creation of a token.</description></item>
        /// </list>
        /// </summary>
        public bool? IsNewToken { get; set; }

        /// <summary>
        /// ID of the token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Indicates if tokenization was successful or not. If this value is false, then the token and isNewToken properties will not be set.
        /// </summary>
        public bool? TokenizationSucceeded { get; set; }
    }
}
