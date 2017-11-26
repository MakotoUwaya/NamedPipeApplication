using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MainApp.Gnavi
{
    public class Rests : ApiBase, ISearchCollection<Rests>
    {
        [JsonIgnore]
        protected override Uri ResourceLocation { get; } = new Uri(ConfigurationManager.AppSettings["rest"].ToString());

        [JsonProperty("@attributes")]
        public Attributes Attributes { get; private set; }

        public IEnumerable<Rest> List
        {
            get
            {
                if (this.ListObject == null)
                {
                    return null;
                }

                if (this.ListObject is JArray)
                {
                    return JsonConvert.DeserializeObject<IEnumerable<Rest>>(this.ListObject.ToString());
                }

                return new List<Rest>
                {
                    JsonConvert.DeserializeObject<Rest>(this.ListObject.ToString())
                };
            }
        }

        [JsonProperty("rest")]
        public object ListObject { get; private set; }

        [JsonProperty("total_hit_count")]
        public int TotalHitCount { get; private set; }

        [JsonProperty("hit_per_page")]
        public int HitPerPage { get; private set; }

        [JsonProperty("page_offset")]
        public int PageOffset { get; private set; }

        public Rests(IDataReader dataReader) : base(dataReader)
        {
        }

        public async Task<Rests> Get(IDictionary<string, string> param)
        {           
            var rests = await this.dataReader?.Get<Rests>(this.ResourceLocation.AddParameters(this.DefaultApiParam.Union(param).ToDictionary(p => p.Key, p => p.Value)));
            if (rests != null)
            {
                this.Attributes = rests.Attributes;
                this.TotalHitCount = rests.TotalHitCount;
                this.HitPerPage = rests.HitPerPage;
                this.PageOffset = rests.PageOffset;
                this.ListObject = rests.ListObject;
            }
            return this;
        }

    }
}
