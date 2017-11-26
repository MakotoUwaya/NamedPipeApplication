using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("garea_Large")]
    public class AreaL
    {
        [JsonProperty("areacode_l")]
        public string Code { get; set; }
        [JsonProperty("areaname_l")]
        public string Name { get; set; }
        [JsonProperty("pref")]
        public Pref Pref { get; set; }
    }

}
