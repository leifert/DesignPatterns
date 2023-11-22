using Adapter.DataProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DataProcessor
{
    internal class DataProcessor : IDataProcessor
    {
        public bool DataProcess()
        {
            Console.WriteLine("Processed data");
            return true;
        }
        public void SendNetworkRequest(string ipAddress, string apiKey)
        {
            Console.WriteLine("Send network request with IP address that requires API Key: " + ipAddress);
        }
    }
}
