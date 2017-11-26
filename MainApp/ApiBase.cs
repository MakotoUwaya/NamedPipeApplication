using System;
using System.Collections.Generic;
using System.Configuration;
using Newtonsoft.Json;

namespace MainApp
{
    public abstract class ApiBase
    {
        [JsonIgnore]
        protected IDataReader dataReader;

        [JsonIgnore]
        protected abstract Uri ResourceLocation { get; }

        [JsonIgnore]
        private IDictionary<string, string> defaultParam;

        [JsonIgnore]
        protected IDictionary<string, string> DefaultApiParam
        {
            get
            {
                if (this.defaultParam == null)
                {
                    this.defaultParam = new Dictionary<string, string>
                    {
                        { "keyid", ConfigurationManager.AppSettings["gnavikeyid"].ToString() },
                        { "format", "json" },
                    };
                }
                return this.defaultParam;
            }
        }

        public ApiBase(IDataReader dataReader)
        {
            this.dataReader = dataReader;
        }
    }
}
