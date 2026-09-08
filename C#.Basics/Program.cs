
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,Pages: 464" using the + operator.() to change "Book List" into "Library". Print the result.
            string title = "Clean Code";
            int pages = 464;
            WriteLine($"Book: {title}, Pages: {pages}");

            #endregion

        }
    }
}
