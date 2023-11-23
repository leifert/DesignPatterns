namespace ProtectionProxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICar car = new CarProxy(new Driver(12));
            car.Drive();
        }
    }
}
