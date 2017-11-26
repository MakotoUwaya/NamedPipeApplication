using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace MainApp
{
    public class HttpDataReader : IDataReader
    {
        public async Task<T> Get<T>(Uri uri)
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(uri);

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(content.Replace("{}", "null"));
            }
            catch (Exception)
            {
                return default(T);
            }
            
        }
    }
}
