using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class NetworkFacade
    {
        private Packet _packet;
        private Socket _socket;
        private Transmission _transmission;

        public NetworkFacade(string ip, string protocol)
        {
            _packet = new Packet(ip);
            _socket = new Socket(protocol);
            _transmission = new Transmission(protocol);
        }

        public void BuildNetworkLayer()
        {
            _packet.BuildPacket();
            _socket.BuildSocket();
        }

        public void SendPacketOverNetwork()
        {
            BuildNetworkLayer();
            _transmission.SendTransmission();
        }
    }
}
