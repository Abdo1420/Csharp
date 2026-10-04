
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //هيتغير في النسخة ومش هيتغير في المتغير الاصلي عشان ستراكت من نوع فاليو 
            #endregion

            #region What happens when a Customer variable is copied into another variable and one variable modifies the object
            //هيتم تغير قيمة الفاليو عند الاتنين لان الكلاس نوعه ريفرانس الاتنين ليهم نفس العنوان بيشاورو علي نفس المتغير
            #endregion
        }
    }
}
