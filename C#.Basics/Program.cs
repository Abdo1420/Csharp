
using System.Drawing;
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.
            Book book = new Book();
        
            WriteLine(book.genre); 
            #endregion

        }
    }
}
