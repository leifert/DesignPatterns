namespace VirtualProxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICar car = new CarProxy();
            car.Drive();
        }
    }
}
