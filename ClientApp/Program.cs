using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using WcfServiceLibrary1;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var factory = new ChannelFactory<IService1>(new NetNamedPipeBinding(NetNamedPipeSecurityMode.None), Consts.ServicePipeUrl))
            {
                var client = factory.CreateChannel();
                client.GetData(15);

                var data = new CompositeType
                {
                    BoolValue = false,
                    StringValue = "Yeah!",
                };

                client.GetDataUsingDataContract(data);
            }
        }
    }
}
