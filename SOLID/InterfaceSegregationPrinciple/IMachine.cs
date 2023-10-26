using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IMachine // Porusuje ISP
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }
}
