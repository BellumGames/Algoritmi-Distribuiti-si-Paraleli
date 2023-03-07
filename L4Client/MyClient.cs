using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace L4Client
{
    public class MyClient
    {
        public TcpClient client = null;
        public NetworkStream stream = null;
        public StreamReader streamReader = null;
        public StreamWriter streamWriter = null;

        public MyClient()
        {
            client = new TcpClient("localhost", 8000);
            stream = client.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            sendInt("Client Sent Message");
        }
        public void sendInt(string val)
        {
            streamWriter.WriteLine(Convert.ToString(val));
            streamWriter.Flush();
        }
        public void receiveInt()
        {
            string val = streamReader.ReadLine();
            Console.WriteLine(val);
        }
    }
}
