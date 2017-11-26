using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("area")]
    public class Area
    {
        [JsonProperty("area_code")]
        public string Code { get; set; }
        [JsonProperty("area_name")]
        public string Name { get; set; }
    }

}
