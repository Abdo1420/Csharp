
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why?
            Book book = new Book();
            WriteLine(book.copiesInStock);
            //الكود اشتغل بنجاح لان حدود انتيرنال هي البروجيكت بالكامل وليس الكلاس فقط

            #endregion
        }
    }
}
