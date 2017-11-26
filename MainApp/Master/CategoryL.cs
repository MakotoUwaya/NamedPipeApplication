using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("category_l")]
    public class CategoryL
    {
        [JsonProperty("category_l_code")]
        public string Code { get; set; } = string.Empty;
        [JsonProperty("category_l_name")]
        public string Name { get; set; } = string.Empty;
    }

}
