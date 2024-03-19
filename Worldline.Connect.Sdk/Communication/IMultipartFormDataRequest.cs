namespace Worldline.Connect.Sdk.Communication
{
    /// <summary>
    /// A representation of a multipart/form-data request.
    /// </summary>
    public interface IMultipartFormDataRequest
    {
        MultipartFormDataObject ToMultipartFormDataObject();
    }
}
