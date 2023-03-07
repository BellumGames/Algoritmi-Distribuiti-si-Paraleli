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
        //Deci ca sa nu uit:
        //Serverul prin Recive Message primeste mesaje de la clienti, in momentul primirii mesajelor de la clienti (clientii pot trimite doar mesaje gen salut) serverul trebuie sa raspund aprin send message cu count ca si index al clientului de asemenea redirectioneaza mesajul primit de la client la fiecare client conectat
        public TcpListener server = null;
        public NetworkStream stream = null;
        public StreamReader streamReader = null;
        public StreamWriter streamWriter = null;
        public static Dictionary<string, string> log = new Dictionary<string, string>();
        public static int count = 0;
        public static int index = 0;

        public MyServer(TcpClient clientSocket)
        {
            count++;
            Console.WriteLine($"Client number #{index} connected");
            log.Add($"Client {index}", "");
            index++;
            stream = clientSocket.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
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
            streamWriter.Flush();
        }

        public void ReciveMessage()
        {

            SendMessage(streamReader.ReadLine().ToString()); //mesaj primit de la client e redirectionat la restu
        }

        void run()
        {
            server = new TcpListener(8000);
            server.Start();
            while (true)
            {
                TcpClient clientSocket = server.AcceptTcpClient();
                new MyServer(clientSocket);
            }
        }
    }
}
