using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("garea_middle")]
    public class AreaM
    {
        [JsonProperty("areacode_m")]
        public string Code { get; set; }
        [JsonProperty("areaname_m")]
        public string Name { get; set; }
        [JsonProperty("garea_large")]
        public AreaL AreaL { get; set; }
        [JsonProperty("pref")]
        public Pref Pref { get; set; }
    }
}
