using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Network
{
    internal class NetworkClient : INetworkClient
    {
        public void SendRequest(string ipAddress)
        {
            Console.WriteLine("Network cllient request sent to ip: "+ ipAddress);
        }
    }
}
