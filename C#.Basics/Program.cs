
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
            #region Using the same books array, use a while loop to print every book title. 
            string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int index = 0;
            while (index<Books.Length)
            {
                WriteLine(Books[index]);
                index++;
            }
            #endregion

        }
    }
}
