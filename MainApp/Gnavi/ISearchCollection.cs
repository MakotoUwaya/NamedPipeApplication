using System.Collections.Generic;
using System.Threading.Tasks;

namespace MainApp.Gnavi
{
    public interface ISearchCollection<T>
    {
        Task<T> Get(IDictionary<string, string> param);
    }
}
