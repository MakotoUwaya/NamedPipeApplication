using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MainApp.Master
{
    public class AreaLs : MasterBase
    {
        [JsonIgnore]
        protected override Uri ResourceLocation { get; } = new Uri(ConfigurationManager.AppSettings["areal"].ToString());

        [JsonProperty("@attributes")]
        public Attributes Attributes { get; private set; }

        [JsonProperty("garea_large")]
        public IEnumerable<AreaL> List { get; private set; }

        public AreaLs(IDataReader dataReader) : base(dataReader)
        {
        }

        public override async Task Load()
        {
            var areaL = await this.dataReader?.Get<AreaLs>(this.ResourceLocation.AddParameters(this.DefaultApiParam));
            this.Attributes = areaL.Attributes;
            this.List = areaL.List;
        }
    }
}
