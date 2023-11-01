namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonDatabase sd1 = SingletonDatabase.GetInstance();
            SingletonDatabase sd2 = SingletonDatabase.GetInstance();

            if (sd1 == sd2) 
            {
                Console.WriteLine("Singleton works, both variables contain the same instance."); ;
            }

            Console.WriteLine(sd1.GetPopulation("Tokyo")); 

        }
    }
}