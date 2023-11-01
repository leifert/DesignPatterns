using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeInheritance
{
    public class Address : IDeepCopyable<Address>
    {
        public string StreetName;
        public int HouseNumber;

        public Address()
        {
            
        }

        public Address(string streetName, int houseName)
        {
            StreetName = streetName;
            HouseNumber = houseName;
        }

        public void CopyTo(Address target)
        {
           target.StreetName = StreetName;
           target.HouseNumber = HouseNumber;
        }


        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
        }
    }
}
