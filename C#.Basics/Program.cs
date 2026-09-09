
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
            #region Using the same books array, use a foreach loop to print every book title. 
            string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string Book in Books) {WriteLine(Book); }
            #endregion

        }
    }
}
