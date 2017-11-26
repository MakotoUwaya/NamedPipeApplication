using System.Collections.Generic;
using System.Threading.Tasks;

namespace MainApp.Gnavi
{
    public class Search<T> where T : ISearchCollection<T>, new()
    {
        public async Task<T> GetAsync(IDictionary<string, string> param)
        {
            return await new T().Get(param);
        }
    }
}
