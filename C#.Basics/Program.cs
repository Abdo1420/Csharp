
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
            #region Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is  greater than 300 and isAvailable is true.Use the && operator. 
            int pages = 464;
            bool isAvailable = true;
            if (isAvailable && pages > 300)
            {
                WriteLine("You can borrow this book");
            }
         
            #endregion

        }
    }
}
