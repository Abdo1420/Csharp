
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
            Book Mybook = new Book { Title = "C#", Pages = 250 };
            WriteLine(Mybook);
            #endregion 

        }
    }
}
