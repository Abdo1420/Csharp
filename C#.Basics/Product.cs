using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

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
        public static void PrintReport(List<Product> catalog, Action<Product> print)//use (action) delegate becose the funcion is print only void type
        {
            foreach (Product item in catalog)
            {
                print(item);
                Console.WriteLine("=====================================");
            }

        }
        public static List<string> TransformProducts(List<Product> ctalog,Func<Product,string>transToStr)//use (Funce) delegate becose transfer to string
        {
            List<string?> SummaryList=new();
            foreach(Product p in ctalog)
            {
                string st = transToStr(p);
                SummaryList.Add(st);
            }
            return SummaryList!;
        }
        public static List<Product> FilterProducts(List<Product> catalog, Predicate<Product> instoke)//use bultin delegate (predicate) becose it return bool 
        {
            List<Product> lowStoke = new();
            foreach(Product p in catalog) { 
                if (instoke(p))
                {
                    lowStoke.Add(p);
                }
            }
            return lowStoke;
        }
        #endregion

    }
}
