﻿namespace PrototypeCopyConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person(
                new[] { "John", "Smith" },
                new Address("London Road", 10)
                );

            var jane = new Person(john);
            jane.Address.HouseNumber = 321;
            Console.WriteLine(john);
            Console.WriteLine(jane);
            //Names: John Smith, Address: StreetName: London Road, HouseNumber: 10
            //Names: John Smith, Address: StreetName: London Road, HouseNumber: 321
        }
    }
}