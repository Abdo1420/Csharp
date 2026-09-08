
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
            #region Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            WriteLine(sb);
            sb.Replace("Book List", "Library");
            WriteLine(sb);

            #endregion

        }
    }
}
