
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?
            Book book = new Book();
            WriteLine(book.password);
            //ايرور لا يمكن طباعة الباسورد عشان البرايفت بتخلينا ناكسيس علي الفاليو في حدود الكلاس فقط 
            #endregion

        }
    }
}
