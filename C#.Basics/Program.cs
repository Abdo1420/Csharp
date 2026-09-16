
using System.Drawing;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it1and print the price if found
            string title = "Clean Code";
            double price = 0;
            WriteLine(TryGetPrice(title, out price));
            WriteLine(price); 
            #endregion
        }
        public static bool TryGetPrice(string title, out double price)
        {
            
          if (title== "Clean Code" )
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }

           
            
        }
    }
}
