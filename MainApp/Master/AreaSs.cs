using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MainApp.Master
{
    public class AreaSs : MasterBase
    {
        [JsonIgnore]
        protected override Uri ResourceLocation { get; } = new Uri(ConfigurationManager.AppSettings["areas"].ToString());

        [JsonProperty("@attributes")]
        public Attributes Attributes { get; private set; }

        [JsonProperty("garea_small")]
        public IEnumerable<AreaS> List { get; private set; }

        public AreaSs(IDataReader dataReader) : base(dataReader)
        {
        }

        public override async Task Load()
        {
            var areaS = await this.dataReader?.Get<AreaSs>(this.ResourceLocation.AddParameters(this.DefaultApiParam));
            this.Attributes = areaS.Attributes;
            this.List = areaS.List;
        }
    }
}
