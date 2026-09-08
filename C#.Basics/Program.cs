
using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Channels;
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
            string name1 = "Clean Code";
            string name2 = "Clean Code";
            WriteLine(ReferenceEquals(name1, name2));
            #endregion

        }
    }
}
