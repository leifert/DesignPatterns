namespace PrototypeInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee john = new Employee(
                new[] { "John", "Smith" },
                new Address("London Road", 10),
                150000);
            

            Employee jane = john.DeepCopy();
            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 321;
            jane.Salary = 120000;

            Console.WriteLine(john);
            Console.WriteLine(jane);
            //Names: John Smith, Address: StreetName: London Road, HouseNumber: 10, Salary: 150000
            //Names: Jane Smith, Address: StreetName: London Road, HouseNumber: 321, Salary: 120000
        }
    }
}