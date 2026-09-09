
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
            #region Write a do-while loop that prints "Checking book..." exactly 3 times. 
            int times = 0;
            do { WriteLine("Checking book...");
                times++;
            }
            while (times < 3);
            #endregion

        }
    }
}
