using Newtonsoft.Json;

namespace MainApp
{
    public class Attributes
    {
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }
    }
}
