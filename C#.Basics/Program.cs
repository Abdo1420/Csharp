
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
            #region Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring".
            string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < Books.Length; i++)
            {
                if (i < 2) { WriteLine(Books[i]); }
                else { break; }
            }
            #endregion

        }
    }
}
