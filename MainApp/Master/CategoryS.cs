using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("category_s")]
    public class CategoryS
    {
        [JsonProperty("category_s_code")]
        public string Code { get; set; }
        [JsonProperty("category_s_name")]
        public string Name { get; set; }
        [JsonProperty("category_l_code")]
        public string CategoryLCode { get; set; }
    }

}
