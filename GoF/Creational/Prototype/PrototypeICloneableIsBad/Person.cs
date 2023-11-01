using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeICloneableIsBad
{
    public class Person : ICloneable
    {
        public string[] Names;
        public Address Address;

        public Person(string[]names, Address address)
        {
            Names = names;
            Address = address;
        }

        public object Clone()
        {
            return new Person(Names, (Address)Address.Clone());  
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ",Names)}, {nameof(Address)}: {Address}";
        }
    }
}
