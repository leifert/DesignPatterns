using AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public interface IVehicleFactory
    {
        //Product A
        IBike CreateBike();
        //Product B
        ICar CreateCar();
    }
}
