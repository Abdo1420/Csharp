
using System.Reflection.Emit;
using static System.Console;
namespace C_.Basics
{
    public class Program
    {
        #region Cataloge
        public static List<Product> catalog = new()

    {
         new Product ( 1, "Laptop", "Electronics", 1200, 10 ),
         new Product ( 2,"Phone", "Electronics", 800, 25 ),
         new Product ( 3, "T-Shirt", "Clothing", 30, 100 ),
         new Product ( 4, "Jeans", "Clothing", 60, 50 ),
         new Product ( 5, "Chocolate", "Food", 5, 200 ),
         new Product ( 6, "Coffee Beans", "Food", 15, 80 ),
         new Product ( 7, "C# Book", "Books", 45, 30 ),
         new Product ( 8, "Novel", "Books", 20, 60 ),
         new Product ( 9,"Headphones", "Electronics", 150, 70 ),
         new Product ( 9,"Jacket", "Clothing", 90, 15 )
    };
        #endregion

        static void Main(string[] args)
        {
            #region Task 01 : Smart Product Search 
            //var electronicsProducts = Product.SearchProducts(catalog, p => p.Category == "Electronics");
            //var cheapProducts = Product.SearchProducts(catalog, p => p.Price < 50);
            //var inStokeProducts = Product.SearchProducts(catalog, p => p.Stock > 0);
            //var clothesProducts = Product.SearchProducts(catalog, (p => p.Category == "Clothing"&&p.Price<100));
            //Console.WriteLine("=====================================");
            //Console.WriteLine("--- Electronics —");
            //Console.WriteLine("---------------------------");
            //foreach (Product item in electronicsProducts)
            //{
            //    Console.WriteLine($" {item.Name}| ${item.Price}|(Stoke: {item.Stock})");
            //    Console.WriteLine("=====================================");
            //}
            //Console.WriteLine("--- Under $50 --- ");
            //Console.WriteLine("---------------------------");
            //foreach (Product item in cheapProducts)
            //{
            //    Console.WriteLine($" {item.Name}| ${item.Price}|(Stoke: {item.Stock})");
            //    Console.WriteLine("=====================================");

            //}
            //Console.WriteLine("--- In Stoke --- ");
            //Console.WriteLine("---------------------------");
            //foreach (Product item in inStokeProducts)
            //{
            //    Console.WriteLine($" {item.Name}| ${item.Price}|(Stoke: {item.Stock})");
            //    Console.WriteLine("=====================================");

            //}
            //Console.WriteLine("--- Clothes Under $100 --- ");
            //Console.WriteLine("---------------------------");
            //foreach (Product item in clothesProducts)
            //{
            //    Console.WriteLine($" {item.Name}| ${item.Price}|(Stoke: {item.Stock})");
            //    Console.WriteLine("=====================================");

            //}

            #endregion
            #region Task 03 : Custom Report Generator
            #region 3.1  Print Reports 
            //Console.WriteLine("=====================================");
            //Console.WriteLine("--- Short Report —");
            //Console.WriteLine("=====================================");
            //Product.PrintReport(catalog, p => Console.WriteLine($"{p.Name}==>${p.Price}"));
            //Console.WriteLine("=====================================");
            //Console.WriteLine("--- Detailed Report —");
            //Console.WriteLine("=====================================");
            //Product.PrintReport(catalog, p => Console.WriteLine($"[{p.Category}]{p.Name}|Price: ${p.Price}|Stock: {p.Stock}"));
            #endregion
            #region 3.2. Transform Products
            Console.WriteLine("--- Summary List —--");
            var summaryList = Product.TransformProducts(catalog, p => ($"{p.Name}  (${p.Price})"));
            foreach (string item in summaryList)
            {
                Console.WriteLine(item);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("--- Price Labels —--");
            var PriceLabel = Product.TransformProducts(catalog, p =>
            {
                string Label = p.Price >= 100 ? "Expensive!" : "Affordable";
                return $"{p.Name}:{Label}";
            });
            foreach (string item in PriceLabel)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------");
            }
            #endregion

            #endregion

        }
    }
}
