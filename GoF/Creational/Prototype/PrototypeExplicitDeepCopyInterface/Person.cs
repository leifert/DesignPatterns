using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExplicitDeepCopyInterface
{
    public class Person : IPrototype<Person>
    {
        public string[] Names;
        public Address Address;

        public Person(string[]names, Address address)
        {
            Names = names;
            Address = address;
        }

        public Person DeepCopy()
        {
            return new Person(Names, Address.DeepCopy());
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ",Names)}, {nameof(Address)}: {Address}";
        }
    }
}
