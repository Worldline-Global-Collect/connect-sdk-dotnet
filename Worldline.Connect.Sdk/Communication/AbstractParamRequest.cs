using System.Collections.Generic;

namespace Worldline.Connect.Sdk.Communication
{
    /// <summary>
    /// Represents a set of request parameters.
    /// </summary>
    public abstract class AbstractParamRequest
    {
        public abstract IEnumerable<RequestParam> ToRequestParameters();
    }
}
