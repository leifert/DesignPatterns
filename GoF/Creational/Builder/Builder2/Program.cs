namespace Builder2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product { Name = "Monitor", Price = 200.90 },
                new Product { Name = "Mouse", Price = 20.40 },
                new Product { Name = "Keyboard", Price = 30.10 },
            };

            var builder = new ProductStockReportBuilder(products);
            var director = new ProductStockReportDirector(builder);
            director.BuildStockReport("");

            var report = builder.GetReport();
            Console.WriteLine(report);

            director.BuildStockReport("OnlyHeader");
            var reportHeader = builder.GetReport();
            Console.WriteLine(reportHeader);
        }
    }
}