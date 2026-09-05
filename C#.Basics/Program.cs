
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            string yeartext = "2026";
            int Year = int.Parse(yeartext);
            WriteLine(yeartext);
            string badText = "abc";
            if (int.TryParse(badText, out int num))
            {
                WriteLine(num);
            }
            else { WriteLine("Invalid number"); }
            #endregion


        }
    }
}
