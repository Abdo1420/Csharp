
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            string title = "Clean Code";
            PrintBookTitle(title); 
            #endregion
        }
        public static void PrintBookTitle(string title)
        {
            WriteLine("Book title: " + title);
        }
    }
}
