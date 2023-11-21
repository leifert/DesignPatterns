namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Without Facade
            Packet packet = new Packet("8.8.8.8");
            Socket socket = new Socket("TCP");
            Transmission transmission = new Transmission("asda");
            packet.BuildPacket();
            socket.BuildSocket();
            transmission.SendTransmission();


            Console.WriteLine("\nWith Facade\n-----------");
            //With Facade
            NetworkFacade networkFacade = new NetworkFacade("8.8.8.8", "TCP");
            networkFacade.SendPacketOverNetwork();
        }
    }
}
