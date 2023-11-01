using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeInheritance
{
    public class Person : IDeepCopyable<Person>
    {
        public string[] Names;
        public Address Address;

        public Person()
        {
            
        }
        public Person(string[]names, Address address)
        {
            Names = names;
            Address = address;
        }

        public void CopyTo(Person target)
        {
            target.Names = (string[])Names.Clone(); 
            target.Address = Address.DeepCopy();
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
        }
    }

   
}
