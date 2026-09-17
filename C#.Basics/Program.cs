
using System.Drawing;
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.

            WriteLine((int)Genre.Fiction); 
            WriteLine((int)Genre.NonFiction); 
            WriteLine((int)Genre.Science); 
            #endregion

        }
    }
}
