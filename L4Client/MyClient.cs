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
        public static string[] data = new string[3];
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
            streamWriter.AutoFlush = true;
            receiveMessage();
            //sendMessage("I am online");
        }

        public void sendMessage(string message)
        {
            streamWriter.WriteLine(message.ToString());
            //streamWriter.Flush();
        }

        public void receiveMessage()
        {
            int index;
            string message = streamReader.ReadLine();
            bool isNumeric = int.TryParse(message, out index);
            if (isNumeric)
            {
                Client.clientIndex = index;
                sendMessage(Client.clientName);
            }
            else 
            {
                data[0] = message.Substring(0, 1);
                data[1] = message.Substring(1, message.Length - 2);
                data[2] = message.Substring(message.Length- 1, 1);
            }
            Console.WriteLine(index.ToString());
        }
    }
}
