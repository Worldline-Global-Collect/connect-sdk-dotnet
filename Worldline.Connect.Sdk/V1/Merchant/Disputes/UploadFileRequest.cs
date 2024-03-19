/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Worldline.Connect.Sdk.Communication;
using Worldline.Connect.Sdk.Domain;

namespace Worldline.Connect.Sdk.V1.Merchant.Disputes
{
    /// <summary>
    /// Multipart/form-data parameters for
    /// <a href="https://apireference.connect.worldline-solutions.com/fileserviceapi/v1/en_US/dotnet/disputes/uploadFile.html">Upload File</a>
    /// </summary>
    public class UploadFileRequest : IMultipartFormDataRequest
    {
        /// <summary>
        /// The file that you will upload as evidence to support a dispute.
        /// </summary>
        public UploadableFile File { get; set; } = null;

        public MultipartFormDataObject ToMultipartFormDataObject()
        {
            var result = new MultipartFormDataObject();
            if (File != null)
            {
                result.AddFile("file", File);
            }
            return result;
        }
    }
}
