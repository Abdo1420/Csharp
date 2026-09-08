
using System.Security.Cryptography;
using System.Threading.Channels;
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.
            string title = "clean code";
            string UpperTitle=title.ToUpper();
            WriteLine(title);
            WriteLine(UpperTitle);
            #endregion

        }
    }
}
