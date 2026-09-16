
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why? 
            int pages = 400;
            WriteLine(AddBonusPages( pages));
            WriteLine(pages);
            #endregion
        }
        public static int AddBonusPages( int  pages)
        {
            pages += 50;
            return pages;
        }
    }
}
