
using System.Drawing;
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.

            Genre genre = Genre.Fiction;
            string genre_string= genre.ToString();
            WriteLine(genre_string); 
            #endregion

        }
    }
}
