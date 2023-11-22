using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Network
{
    internal interface INetworkClient
    {
        void SendRequest(string ipAddress);
    }
}
