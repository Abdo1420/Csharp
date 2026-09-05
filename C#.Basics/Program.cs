
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int Copies = 100;
            object opj = Copies;
            WriteLine(opj);
            int New_Copies=(int)opj;
            WriteLine(New_Copies);
            #endregion


        }
    }
}
