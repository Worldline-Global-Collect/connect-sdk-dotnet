/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class DisputeCreationDetail
    {
        /// <summary>
        /// The date and time of creation of this dispute, in yyyyMMddHHmmss format.
        /// </summary>
        public string DisputeCreationDate { get; set; }

        /// <summary>
        /// The originator of this dispute, which is either Worldline or you as our client.
        /// </summary>
        public string DisputeOriginator { get; set; }

        /// <summary>
        /// The user account name of the dispute creator.
        /// </summary>
        public string UserName { get; set; }
    }
}
