namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        public static int Area(Rectangle r) => r.Width * r.Height;
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2,3);
            Console.WriteLine($"{r} has area {Area(r)}");

            Rectangle sq = new Square();
            sq.Width = 2;
            Console.WriteLine($"{sq} has area {Area(sq)}");
        }
    }
}