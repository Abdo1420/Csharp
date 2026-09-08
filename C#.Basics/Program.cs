
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
            #region Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            WriteLine(sb);
            #endregion

        }
    }
}
