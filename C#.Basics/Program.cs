
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            //هو كلاس يمكنه انشاء اوبجيكت سبشيال يستقبل اي نوع من انواع الفاليوز سواء فاليو تايب او ريفرانس تايب ويطلق عليه جينارك بدل من اوبجيكت 
            //نستخدمه لتامين الداتا المدخلة من اليوز الي مكانها الخاص وعدم تكرار الكود من كل نوع واستبعاد عملية البوكسينج والانبوكسينج الخاصة بالاوبجيكت ويساعد للوصول الي الكلين كود
            #endregion
            #region Q2: Write a generic class Container<T> with Add and Get methods.
            Container<int> intCon = new Container<int>(1);
            Container<double> doubleCon = new Container<double>(5.5);
            Container<string> stringCon = new Container<string>("one");
            intCon.Add(3);
            WriteLine(intCon.Get());
            #endregion
            

        }
    }
}
