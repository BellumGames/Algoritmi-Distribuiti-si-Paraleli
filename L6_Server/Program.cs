using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.ServiceModel;
using System.Text;

namespace L6_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NetTcpBinding binding = new NetTcpBinding();
            Uri baseAddress = new Uri("net.tcp://localhost:8000/wcfserver");
            using (ServiceHost serviceHost = new ServiceHost(typeof(WCFServer), baseAddress))
            {
                serviceHost.AddServiceEndpoint(typeof(IWCFServer), binding, baseAddress);
                serviceHost.Open();
                Console.WriteLine($"The WCF server is ready at {baseAddress}.");
                Console.WriteLine("Press <ENTER> to terminate service...");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
