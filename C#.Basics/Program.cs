
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect tosee, and why?
            double[] prices = { 25.5, 40.0 };
            WriteLine(ApplyDiscount(prices));
            WriteLine(prices[0]);
            //الناتج هنا واحد لان الارراي اصلا ريفرانس الاتنين بشاورو عللي نفس الفاليو
            #endregion
        }
        public static double ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
            return prices[0];
        }
    }
}
