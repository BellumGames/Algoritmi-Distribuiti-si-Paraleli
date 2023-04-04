using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6_Server
{
    internal class WCFServer : IWCFServer
    {
        public string SayHello()
        {
            return "Hello from the IHello implementation on the server.";
        }
    }
}
