using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MainApp.Master
{
    public class AreaMs : MasterBase
    {
        [JsonIgnore]
        protected override Uri ResourceLocation { get; } = new Uri(ConfigurationManager.AppSettings["aream"].ToString());

        [JsonProperty("@attributes")]
        public Attributes Attributes { get; private set; }

        [JsonProperty("garea_middle")]
        public IEnumerable<AreaM> List { get; private set; }

        public AreaMs(IDataReader dataReader) : base(dataReader)
        {
        }

        public override async Task Load()
        {
            var areaM = await this.dataReader?.Get<AreaMs>(this.ResourceLocation.AddParameters(this.DefaultApiParam));
            this.Attributes = areaM.Attributes;
            this.List = areaM.List;
        }
    }
}
