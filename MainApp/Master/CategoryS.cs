using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("category_s")]
    public class CategoryS
    {
        [JsonProperty("category_s_code")]
        public string Code { get; set; } = string.Empty;
        [JsonProperty("category_s_name")]
        public string Name { get; set; } = string.Empty;
        [JsonProperty("category_l_code")]
        public string CategoryLCode { get; set; } = string.Empty;
    }

}
