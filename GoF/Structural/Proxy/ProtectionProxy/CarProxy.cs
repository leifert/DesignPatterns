using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectionProxy
{
    internal class CarProxy : ICar
    {
        private Driver _driver;
        private Car _car = new Car();
        public CarProxy(Driver driver)
        {
            _driver = driver;
        }
        public void Drive()
        {
            if (_driver.Age >=18)
            {
                _car.Drive();
            }
            else
            {
                Console.WriteLine("Too young");
            }
        }
    }
}
