using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace L6_Server
{
    [ServiceContract]
    public interface IWCFServer
    {
        [OperationContract] string ConnectToDB(string querry);
    }
}
