using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using L6_Server;

namespace L6_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NetTcpBinding binding = new NetTcpBinding();
            string url = "net.tcp://localhost:8000/wcfserver";
            EndpointAddress address = new EndpointAddress(url);
            string querry = "SELECT * FROM dbo.Student";
            //querry = Console.ReadLine();
            using (ChannelFactory<IWCFServer> channelFactory = new ChannelFactory<IWCFServer>(binding, address))
            {
                IWCFServer server = channelFactory.CreateChannel();
                Console.WriteLine(server.ConnectToDB(querry));
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
