using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MainApp.Master
{
    public class AreaCollection : MasterBase
    {
        [JsonIgnore]
        protected override Uri ResourceLocation { get; } = new Uri(ConfigurationManager.AppSettings["area"].ToString());

        [JsonProperty("@attributes")]
        public Attributes Attributes { get; private set; }

        [JsonProperty("area")]
        public IList<Area> List { get; private set; }

        public AreaCollection(IDataReader dataReader) : base(dataReader)
        {
        }

        public override async Task Load()
        {
            var areaL = await this.dataReader?.Get<AreaCollection>(this.ResourceLocation.AddParameters(this.DefaultApiParam));
            this.Attributes = areaL.Attributes;
            this.List = areaL.List;
            this.List.Insert(0, new Area());
        }
    }
}
