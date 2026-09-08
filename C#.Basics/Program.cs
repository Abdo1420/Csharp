
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
            #region Build the same sentence as above, but using string interpolation ($"...").
            string title = "Clean Code";
            int pages = 464;
            WriteLine($"Book: {title}, Pages: {pages}");

            #endregion

        }
    }
}
