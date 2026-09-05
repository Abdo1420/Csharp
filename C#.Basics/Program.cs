
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            try
            {
                int num1 = 10;
                int num2 = 0;
                WriteLine(num1 / num2);
            }
            catch (Exception ex)
            {
                WriteLine("Cannot divide by zero");
            }
            finally { WriteLine("Done"); }
            #endregion

        }
    }
}
