using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("garea_small")]
    public class AreaS
    {
        [JsonProperty("areacode_s")]
        public string Code { get; set; }
        [JsonProperty("areaname_s")]
        public string Name { get; set; }
        [JsonProperty("garea_middle")]
        public AreaM AreaM { get; set; }
        [JsonProperty("garea_large")]
        public AreaL AreaL { get; set; }
        [JsonProperty("pref")]
        public Pref Pref { get; set; }
    }
}
