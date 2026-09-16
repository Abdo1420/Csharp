
using System.Drawing;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages.
                       
            PrintBookInfo(pages:650,title:"C Sharp");
            #endregion

        }
        public static void PrintBookInfo(string title, int pages = 300)
        {

            WriteLine($"Book: {title}, Pages: {pages}");


        }
    }
}
