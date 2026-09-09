
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
            #region Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code.
            string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < Books.Length; i++) {
                WriteLine(i + 1 +"."+ Books[i]);
            }
            #endregion

        }
    }
}
