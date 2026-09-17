using Microsoft.VisualBasic;
using System.Drawing;
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to attempt the conversion.Print "Unknown genre" if it fails.
            string genreText = "Mystery";

           bool flag=Enum.TryParse<Genre>(genreText,out Genre genre);
            if (!flag)
            {
                WriteLine("Unknown genre");
            }
            else
            {
                WriteLine($"gener= {genre}");
            }
            #endregion

        }
    }
}
