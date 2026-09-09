
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
            #region Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".
            int pages = 464;
            if (pages > 300)
            {
                WriteLine("Long Book");
            }
            else
            {
                WriteLine("Short Book");
            }
            #endregion

        }
    }
}
