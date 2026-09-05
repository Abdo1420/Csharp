
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            Book Mybook = new Book { Title = "C#", Pages = 410 };
            WriteLine(Mybook.ToString());
            WriteLine(Mybook.Equals(Mybook));
            WriteLine(Mybook.GetHashCode());
            WriteLine(Mybook.GetType());

            #endregion


        }
    }
}
