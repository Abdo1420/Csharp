
using System.Drawing;
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given int genreNumber = 1;, cast it into a Genre value and print the result. 

            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;
            WriteLine(genre); 
            #endregion

        }
    }
}
