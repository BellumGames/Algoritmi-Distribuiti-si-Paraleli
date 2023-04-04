using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;

namespace L6_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppSettingsReader reader = new AppSettingsReader();
            int port = (int)reader.GetValue("port", typeof(int));
            string objectURL = (string)reader.GetValue("objectURL", typeof(string));
            // Creating a TcpChannel on the 8888 port and binding it for use.
            TcpChannel channel = new TcpChannel(port);
            ChannelServices.RegisterChannel(channel, true);
            // Registering the Hello class on the 'tcp://localhost:8888/hello' address.
            // When the Activator.GetObject method is called this is the URL that will have to be given to access the IHello interface.RemotingConfiguration.
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Hello), objectURL, WellKnownObjectMode.SingleCall);
            // Waiting for any clients to use the server.
            Console.WriteLine("The server is ready, press any key to close the console");
            Console.ReadKey();
        }
    }
}
