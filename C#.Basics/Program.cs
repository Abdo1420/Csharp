
using System.Drawing;
using System.Runtime.Intrinsics.X86;
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
            #region Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,use return to exit the method early instead of printing anything.
            string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
           void PrintFirstBook(string[] Books)
            {
                if (Books.Length == 0)
                {
                    return;
                }
                else
                {
                    Write( Books[0]);
                }
            }
            PrintFirstBook(Books);

            #endregion

        }
    }
}
