
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add a public string Title; field to Book. Set it and print it from Main.
            Book book = new Book();
            book.Title = "C Sharp";
            WriteLine(book.Title); 
            #endregion

        }
    }
}
