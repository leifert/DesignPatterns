using AbstractFactory.Factories;
using AbstractFactory.Products;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory regularFactory = new RegularVehicleFactory();

            IBike regularBike = regularFactory.CreateBike();
            regularBike.GetDetails();

            ICar regularCar = regularFactory.CreateCar();
            regularCar.GetDetails();


            IVehicleFactory sportsFactory = new SportsVehicleFactory();

            IBike sportsBike = sportsFactory.CreateBike();
            sportsBike.GetDetails();

            ICar sportsCar = sportsFactory.CreateCar();
            sportsCar.GetDetails();
        }
    }
}