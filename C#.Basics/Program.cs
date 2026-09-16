
using System.Drawing;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a  new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Lengthafterward.
            double[] price = { 10.0, 12.5 };
            WriteLine(price.Length);
            ReplaceArray(ref price);
            WriteLine(price.Length); 
            #endregion
        }
        public static double ReplaceArray(ref double[] prices)
        {
            double[] newPrices = new double[3];
            prices = newPrices;
            return prices[0];

           
            
        }
    }
}
