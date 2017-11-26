using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MainApp.Master
{
    public class CategoryLs : MasterBase
    {
        [JsonIgnore]
        protected override Uri ResourceLocation { get; } = new Uri(ConfigurationManager.AppSettings["categoryl"].ToString());

        [JsonProperty("@attributes")]
        public Attributes Attributes { get; private set; }

        [JsonProperty("category_l")]
        public IEnumerable<CategoryL> List { get; private set; }

        public CategoryLs(IDataReader dataReader) : base(dataReader)
        {
        }

        public override async Task Load()
        {
            var categoryLs = await this.dataReader?.Get<CategoryLs>(this.ResourceLocation.AddParameters(this.DefaultApiParam));
            this.Attributes = categoryLs.Attributes;
            this.List = categoryLs.List;
        }
    }
}
