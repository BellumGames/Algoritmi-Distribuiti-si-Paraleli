using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace L4Server
{
    class MyServer
    {
        TcpListener server = null;
        NetworkStream stream = null;
        StreamReader streamReader = null;
        StreamWriter streamWriter = null;
        public MyServer(TcpClient clientSocket)
        {
            stream = clientSocket.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            receiveInt();
            stream.Close();
        }
        public MyServer()
        {
            Thread thread = new Thread(new ThreadStart(run));
            thread.Start();
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
