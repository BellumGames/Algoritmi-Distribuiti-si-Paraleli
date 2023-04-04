using L6_Server;
using System;
using System.Configuration;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Security.Policy;
using System.Threading;

namespace L6_Client 
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSettingsReader reader = new AppSettingsReader();
            string serverObjectURL = (string)reader.GetValue("serverObjectURL", typeof(string));
            Thread.Sleep(1000); // Wait for the server to start.
            IHello helloImplementation = null;
            // Creating a TcpChannel and binding it in order to use it for Remoting.
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, true);
            try
            {
                // The activator will look for any bound implementation of the IHello interface on the specified URL.
                 helloImplementation = Activator.GetObject(typeof(IHello), serverObjectURL) as IHello;
            }
            catch (RemotingException rex)
            {
                Console.WriteLine(string.Format("Error: RemotingException encoutered - {0}", rex.Message));
            }
            catch (MemberAccessException maex)
            {
                Console.WriteLine(string.Format("Error: MemberAccessException encoutered - {0}",
               maex.Message));
            }
            // Calling the SayHello method through the implementation.
            string message = helloImplementation.SayHello();
            Console.WriteLine(string.Format("The server says: '{0}'", message));
            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();
        }
    }
}