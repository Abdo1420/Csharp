
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
            #region Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a  variable sizeLabel(same rule as question 8: long if pages > 300).
            int pages = 464;
            string sizeLabel = pages > 300 ? "Long Book":"Short Book";
            WriteLine(sizeLabel);
            #endregion

        }
    }
}
