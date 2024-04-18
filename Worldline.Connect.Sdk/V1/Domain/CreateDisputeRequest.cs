/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class CreateDisputeRequest
    {
        /// <summary>
        /// The amount of money that is to be disputed.
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// The name of the person on your side who can be contacted regarding this dispute.
        /// </summary>
        public string ContactPerson { get; set; }

        /// <summary>
        /// The email address of the contact person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The email address to which the reply message will be sent.
        /// </summary>
        public string ReplyTo { get; set; }

        /// <summary>
        /// The message sent from you to Worldline.
        /// </summary>
        public string RequestMessage { get; set; }
    }
}
