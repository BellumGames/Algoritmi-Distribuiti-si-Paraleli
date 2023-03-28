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
            streamWriter.AutoFlush = true;
            ReceiveMessage();
        }

        public void SendMessage(string message)
        {
            streamWriter.WriteLine(message);
        }

        public void ReceiveMessage()
        {
            int index;
            string message = streamReader.ReadLine();
            bool isNumeric = int.TryParse(message, out index);
            if (isNumeric)
            {
                string toSend = string.Empty;
                Client.clientIndex = index;
                toSend += Client.clientIndex + Client.clientName;
                SendMessage(toSend);
            }
            else if (message.Substring(0, 4).Equals("FLAG"))
            {
                string[] data = message.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < data.Length; i++) 
                {
                    int nr = int.Parse(data[i].Substring(0, 1));
                    string name = data[i].Substring(1, data[i].Length - 1);
                    Client.catalogue.Add(nr, name);
                }
            }
            else 
            {
                int source = int.Parse(message.Substring(0, 1));
                int destination = int.Parse(message.Substring(message.Length - 1, 1));
                message = message.Substring(1, message.Length - 1);
                if (destination == Client.clientIndex) 
                {
                    Client.log[source].Add(message);
                }
            }
        }
    }
}
