using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("garea_Large")]
    public class AreaL
    {
        [JsonProperty("areacode_l")]
        public string Code { get; set; } = string.Empty;
        [JsonProperty("areaname_l")]
        public string Name { get; set; } = string.Empty;
        [JsonProperty("pref")]
        public Pref Pref { get; set; } = new Pref();
    }

}
