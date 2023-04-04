using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace L6_Client
{
    [ServiceContract]
    public interface IWCFServer
    {
        [OperationContract] string SayHello();
    }
}
