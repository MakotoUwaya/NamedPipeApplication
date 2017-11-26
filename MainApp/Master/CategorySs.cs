using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MainApp.Master
{
    public class CategorySs : MasterBase
    {
        [JsonIgnore]
        protected override Uri ResourceLocation { get; } = new Uri(ConfigurationManager.AppSettings["categorys"].ToString());

        [JsonProperty("@attributes")]
        public Attributes Attributes { get; private set; }

        [JsonProperty("category_s")]
        public IEnumerable<CategoryS> List { get; private set; }

        public CategorySs(IDataReader dataReader) : base(dataReader)
        {
        }

        public override async Task Load()
        {
            var categorySs = await this.dataReader?.Get<CategorySs>(this.ResourceLocation.AddParameters(this.DefaultApiParam));
            this.Attributes = categorySs.Attributes;
            this.List = categorySs.List;
        }
    }
}
