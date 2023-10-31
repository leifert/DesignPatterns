using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Point
    {
        private double x, y;

        //factory method
        //public static Point NewCartesianPoint(double x, double y)
        //{
        //    return new Point(x, y);
        //}
        //public static Point NewPolarPoint(double rho,double theta)
        //{
        //    return new Point(rho*Math.Cos(theta), rho*Math.Sin(theta));
        //}


        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }
    }
}
