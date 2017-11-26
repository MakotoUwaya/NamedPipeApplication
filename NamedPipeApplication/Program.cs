using System;
using System.ServiceModel;
using WcfServiceLibrary1;

namespace NamedPipeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Service1), new Uri(Consts.ServicePipeUrl)))
            {
                host.AddServiceEndpoint(typeof(IService1),
                    new NetNamedPipeBinding(NetNamedPipeSecurityMode.None), string.Empty);

                host.Open();

                Console.WriteLine("press enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
