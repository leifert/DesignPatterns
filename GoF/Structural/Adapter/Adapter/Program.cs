using Adapter.DataProcessor;
using Adapter.Network;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Without Adapter
            INetworkClient network = new NetworkClient();
            network.SendRequest("8.8.8.8");

            IDataProcessor dataProcessor = new DataProcessor.DataProcessor();
            dataProcessor.SendNetworkRequest("8.8.8.7", "564s684fs654f6sd1f");

            //With Adapter
            NetworkAdapter adapter = new NetworkAdapter(dataProcessor);
            adapter.SendRequest("8.7.7.7");
        }
    }
}
