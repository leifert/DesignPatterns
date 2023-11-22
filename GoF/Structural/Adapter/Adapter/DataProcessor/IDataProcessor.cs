using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DataProcessor
{
    internal interface IDataProcessor
    {
        bool DataProcess();
        void SendNetworkRequest(string ipAddress, string apiKey);
    }
}
