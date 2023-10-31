namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var point = Point.NewPolarPoint(1.0, 2.0);
            Console.WriteLine(point);
        }
    }
}