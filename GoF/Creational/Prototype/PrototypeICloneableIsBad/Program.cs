namespace PrototypeICloneableIsBad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person(
                new[] { "John", "Smith" },
                new Address("London Road", 10)
                );

            var jane = (Person)john.Clone();
            jane.Address.HouseNumber = 321;

            //shallow copy
            Console.WriteLine(john);
            Console.WriteLine(jane);
            //Names: John Smith, Address: StreetName: London Road, HouseNumber: 321
            //Names: John Smith, Address: StreetName: London Road, HouseNumber: 321

            //deep copy add to Address : ICloneable
            Console.WriteLine(john);
            Console.WriteLine(jane);
            //Names: John Smith, Address: StreetName: London Road, HouseNumber: 321
            //Names: John Smith, Address: StreetName: London Road, HouseNumber: 10
        }
    }
}