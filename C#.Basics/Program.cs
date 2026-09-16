
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.  Call it and print pages afterward. How is the result different from question 5 ?
                int pages = 400;
            WriteLine(AddBonusPages(ref pages));
            WriteLine(pages);
            //لان هنا انا بصيت البراميتر باي ريفرانص بقا بيشاور علي الفاليو الحقيقي ف اي تغير هيسمع في الفاليو نفسه
            #endregion
        }
        public static int AddBonusPages(ref int  pages)
        {
            pages += 50;
            return pages;
        }
    }
}
