using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace L4Server
{
    public class MyServer
    {
        public TcpListener server = null;
        public NetworkStream stream = null;
        public StreamReader streamReader = null;
        public StreamWriter streamWriter = null;
        public Dictionary<int, string> catalogue = new Dictionary<int, string>();
        public static int index = 0;

        public MyServer(TcpClient clientSocket)
        {
            stream = clientSocket.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            streamWriter.AutoFlush = true;
            Console.WriteLine($"Client number #{index} connected");
            catalogue.Add(index, string.Empty);
            SendMessage(index.ToString());
            index++;
            ReciveMessage();
            stream.Close();
        }

        public MyServer()
        {
            Thread thread = new Thread(new ThreadStart(run));
            thread.Start();
        }

        public void SendMessage(string message)
        {
            streamWriter.WriteLine(message);
        }

        public void ReciveMessage()
        {
            string message = streamReader.ReadLine().ToString();
            int i = int.Parse(message.Substring(0, 1)); //index sursa
            if (!int.TryParse(message.Substring(message.Length - 1, 1), out _)) //daca ulimu caracter din mesajul venit nu e int atunci nu e mesaj propriu-zis
            {
                catalogue[i] = message.Substring(1, message.Length - 1); //se atribuie numele in catalog spre exe 0Darius
                string userList = "FLAG ";
                foreach (var item in catalogue) 
                {
                    userList += item.Key + item.Value + " ";
                }
                SendMessage(userList);
            }
            else 
            {
                string first = message.Substring(0, 1); //0
                string second = message.Substring(1, message.Length - 1);//Salutbro!1
                message = first + catalogue[i] + ": " + second; //0Darius: Salut bro!1
                SendMessage(message);
            }
        }

        void run()
        {
            server = new TcpListener(System.Net.IPAddress.Any, 8000);
            server.Start();
            while (true)
            {
                if(index == 10)
                    Environment.Exit(-1);
                TcpClient clientSocket = server.AcceptTcpClient();
                new MyServer(clientSocket);
            }
        }
    }
}
