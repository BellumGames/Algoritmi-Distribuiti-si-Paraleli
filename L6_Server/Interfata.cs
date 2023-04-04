using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6_Server
{
    // The interface used to communicate between the client and
    // the server using .NET Remoting.
    public interface IHello
    {
        // Returns a 'hello world' message to the caller.
        // <returns>The message</returns>
        string SayHello();
    }
}
