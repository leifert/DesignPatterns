using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
           //
        }
    }
}
