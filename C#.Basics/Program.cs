
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declare an int pages = 300; then store it in a double variable without using a cast.
            int Pages = 300;
            double Douple_Pages = Pages;
            WriteLine($"Douple Pages = {Douple_Pages}");
            WriteLine($"Pages = {Pages}");
            #endregion

        }
    }
}
