/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using Newtonsoft.Json;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class RedirectDataBase
    {
        [JsonProperty(PropertyName = "RETURNMAC")]
        public string RETURNMAC { get; set; } = null;

        public string RedirectURL { get; set; } = null;
    }
}
