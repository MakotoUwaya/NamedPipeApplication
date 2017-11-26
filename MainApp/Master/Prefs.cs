using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MainApp.Master
{
    public class Prefs : MasterBase
    {
        [JsonIgnore]
        protected override Uri ResourceLocation { get; } = new Uri(ConfigurationManager.AppSettings["prefurl"].ToString());

        [JsonProperty("@attributes")]
        public Attributes Attributes { get; private set; }

        [JsonProperty("pref")]
        public IList<Pref> List { get; private set; }

        public Prefs(IDataReader dataReader) : base(dataReader)
        {
        }

        public override async Task Load()
        {
            var prefs = await this.dataReader?.Get<Prefs>(this.ResourceLocation.AddParameters(this.DefaultApiParam));
            this.Attributes = prefs.Attributes;
            this.List = prefs.List;
            this.List.Insert(0, new Pref());
        }
    }
}
