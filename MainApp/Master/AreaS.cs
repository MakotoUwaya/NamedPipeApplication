using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("garea_small")]
    public class AreaS
    {
        [JsonProperty("areacode_s")]
        public string Code { get; set; } = string.Empty;
        [JsonProperty("areaname_s")]
        public string Name { get; set; } = string.Empty;
        [JsonProperty("garea_middle")]
        public AreaM AreaM { get; set; } = new AreaM();
        [JsonProperty("garea_large")]
        public AreaL AreaL { get; set; } = new AreaL();
        [JsonProperty("pref")]
        public Pref Pref { get; set; } = new Pref();
    }
}
