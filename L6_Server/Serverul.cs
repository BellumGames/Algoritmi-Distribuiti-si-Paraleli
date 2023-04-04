using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6_Server
{
    // A remotable object (MarshalByRefObject makes it remotable) that implements the IHello interface.
    public class Hello : MarshalByRefObject, IHello
    {
        #region Implementation of IHello
        // Returns a 'hello world' message to the caller.
        // <returns>The message</returns>
        public string SayHello()
        {
            return "Hello from the IHello implementation on the server.";
        }
        #endregion
    }
}
