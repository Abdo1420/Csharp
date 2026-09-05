
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declare a double price = 49.99; then convert it into an int using a cast.
            double price = 49.99;
            int Reale_price = (int)price;
            WriteLine($"Price = {price}");
            WriteLine($"Reale_price = {Reale_price}");
            #endregion

        }
    }
}
