using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("garea_middle")]
    public class AreaM
    {
        [JsonProperty("areacode_m")]
        public string Code { get; set; } = string.Empty;
        [JsonProperty("areaname_m")]
        public string Name { get; set; } = string.Empty;
        [JsonProperty("garea_large")]
        public AreaL AreaL { get; set; } = new AreaL();
        [JsonProperty("pref")]
        public Pref Pref { get; set; } = new Pref();
    }
}
