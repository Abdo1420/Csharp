
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
            #region Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).
            string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < Books.Length; i++)
            {
                if (i ==1) { continue; }
                else { WriteLine(Books[i]); }
            }
            #endregion

        }
    }
}
