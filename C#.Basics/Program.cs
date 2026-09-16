
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a method called PrintWelcomeMessage that takes no parameters and prints"Welcome to the Library!".Call it from Main.
                        PrintWelcomeMessage(); 
            #endregion
        }
        public static void PrintWelcomeMessage()
        {
            WriteLine("Welcome to the Library!");
        }
    }
}
