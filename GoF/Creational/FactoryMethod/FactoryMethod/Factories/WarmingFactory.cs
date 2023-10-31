using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
            return new WarmingManager(temperature);
        }
    }
}
