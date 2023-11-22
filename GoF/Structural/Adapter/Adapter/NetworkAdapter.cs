using Adapter.DataProcessor;
using Adapter.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class NetworkAdapter : INetworkClient
    {
        private readonly IDataProcessor _dataProcessor;
        public NetworkAdapter(IDataProcessor dataProcessor)
        {
            _dataProcessor = dataProcessor;
        }
        public void SendRequest(string ipAddress)
        {
            var apiKey = "35sd4f435sd4f3sd5";
            _dataProcessor.SendNetworkRequest(ipAddress, apiKey);
        }
    }
}
