using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Packet
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string IP { get; set; }
        public Packet(string ip)
        {
            IP = ip;
        }
        public void BuildPacket()
        {
            Console.WriteLine("Packet built");
        }
    }
}
