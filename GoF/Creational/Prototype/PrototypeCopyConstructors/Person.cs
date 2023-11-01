using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCopyConstructors
{
    public class Person
    {
        public string[] Names;
        public Address Address;

        public Person(string[]names, Address address)
        {
            Names = names;
            Address = address;
        }
        public Person(Person otherPerson)
        {
            Names=otherPerson.Names;
            Address=new Address(otherPerson.Address);
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ",Names)}, {nameof(Address)}: {Address}";
        }
    }
}
