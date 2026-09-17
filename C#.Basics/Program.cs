
using System.Drawing;
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and print the result.

            string genreText = "Science";
           
            Genre genre = Enum.Parse<Genre>( genreText);
            WriteLine(genre);
            #endregion

        }
    }
}
