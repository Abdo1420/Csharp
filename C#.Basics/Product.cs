using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public class Product
    {

        #region properts
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; } // "Electronics", "Clothing", "Food", "Books" 
        public decimal Price { get; set; }
        public int Stock { get; set; }

        #endregion
        #region constractor
        public Product(int id, string? name, string? category, decimal price, int stock)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }
        #endregion
        #region methods
        public static List<Product> SearchProducts(List<Product> catalog, Func<Product, bool> condition)
        {
            List<Product> result = new();
            foreach (Product item in catalog)
            {
                if (condition(item))
                    result.Add(item);
            }
            return result;
        }
        public static void PrintReport(List<Product> catalog, Action<Product> print)
        {
            foreach (Product item in catalog)
            {
                print(item);
                Console.WriteLine("=====================================");
            }

        }
        #endregion

    }
}
