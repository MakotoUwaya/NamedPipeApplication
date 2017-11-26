using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("pref")]
    public class Pref
    {
        [JsonProperty("pref_code")]
        public string PrefCode { get; set; }
        [JsonProperty("pref_name")]
        public string PrefName { get; set; }
        [JsonProperty("area_code")]
        public string AreaCode { get; set; }
    }
}
