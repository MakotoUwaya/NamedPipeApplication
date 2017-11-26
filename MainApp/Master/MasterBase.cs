using System.Threading.Tasks;

namespace MainApp
{
    public abstract class MasterBase : ApiBase
    {
        public abstract Task Load();

        public MasterBase(IDataReader dataReader) : base(dataReader)
        {            
        }
    }
}
