using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
            return new CoolingManager(temperature);
        }
    }
}
