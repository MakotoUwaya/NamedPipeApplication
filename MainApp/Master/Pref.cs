using System;
using Newtonsoft.Json;

namespace MainApp.Master
{
    [JsonObject("pref")]
    public class Pref : IEquatable<Pref>
    {
        [JsonProperty("pref_code")]
        public string Code { get; set; } = string.Empty;
        [JsonProperty("pref_name")]
        public string Name { get; set; } = string.Empty;
        [JsonProperty("area_code")]
        public string AreaCode { get; set; } = string.Empty;

        public bool Equals(Pref other)
        {
            return this.Code == other.Code;
        }
    }
}
