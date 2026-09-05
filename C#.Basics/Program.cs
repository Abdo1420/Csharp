
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            int Pages = 464;
            string Pagestext = Pages.ToString();
            WriteLine(Pagestext.GetType());

            #endregion


        }
    }
}
