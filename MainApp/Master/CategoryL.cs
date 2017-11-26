using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("category_l")]
    public class CategoryL
    {
        [JsonProperty("category_l_code")]
        public string Code { get; set; }
        [JsonProperty("category_l_name")]
        public string Name { get; set; }
    }

}
