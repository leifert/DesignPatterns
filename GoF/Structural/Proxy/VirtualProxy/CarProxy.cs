using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualProxy
{
    internal class CarProxy : ICar
    {
        private Car _car;
        public void Drive()
        {
            if (_car == null)
            {
                _car = new Car();
            }
            _car.Drive();
        }
    }
}
