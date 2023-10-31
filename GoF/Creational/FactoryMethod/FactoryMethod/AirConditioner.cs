using FactoryMethod.Factories;
using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public enum Actions
    {
        Cooling,
        Warming
    }
    public class AirConditioner
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;
        private AirConditioner()
        {
            _factories = new Dictionary<Actions, AirConditionerFactory>
            {
                {Actions.Cooling, new CoolingFactory() },
                {Actions.Warming, new WarmingFactory() },

            };
        }

        public static AirConditioner InitializeFactories()
        {
            return new AirConditioner();
        }

        public IAirConditioner ExecuteCreation(Actions action, double temperature)
        {
            return _factories[action].Create(temperature);

        }
    }
}
