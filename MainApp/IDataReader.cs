using System;
using System.Threading.Tasks;

namespace MainApp
{
    public interface IDataReader
    {
        Task<T> Get<T>(Uri uri);
    }
}
