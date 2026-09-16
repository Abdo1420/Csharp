
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            int[,] shelfCopies = new int[2, 2] { { 3, 5 }, { 1, 4 } };
            WriteLine(shelfCopies[1, 0]); 
            #endregion
        }
    }
}
