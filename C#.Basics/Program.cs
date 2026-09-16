
using System.Drawing;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. Call it with three book titles.
            PrintAllTitles("C sharp", "Java", "CPP");

            #endregion

        }
        public static void PrintAllTitles(params string[] titles)
        {

      
            foreach (string title in titles)
            {
                WriteLine(title);
            }

        }
    }
}
