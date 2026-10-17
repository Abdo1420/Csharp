
using System.Security.Cryptography.X509Certificates;
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
            doubleCon.Add(10.99);
            WriteLine(doubleCon.Get());
            stringCon.Add("anbdooo");
            WriteLine(stringCon.Get());
            #endregion
            #region Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            //هو كلاس يقوم بانشاء اوبجيكت يحمل نوعين متشابهين او مختلفين من اي نوع داتا سواء ريفرانس او فاليو
            WriteLine("========== Pair =================");
            Pair<int, string> pair = new Pair<int, string>(1, "one");
            WriteLine(pair.getFirst());
            WriteLine(pair.getSocend());
            WriteLine(pair.ToString());
            #endregion
            #region Q4: What is a generic method? Write Swap<T> method.
            //هي ميثود يمكنها ارجاع قيمة من اي نوع ويمكن استخدمها علي اي نوع فاليو سواء ريفرانس او فاليو
            int num1 = 10;
            int num2 = 5;
            WriteLine("========== generic method =================");
            WriteLine("------------ Before Swap-------------");
            WriteLine($"Num1 = {num1}");
            WriteLine($"Num2 = {num2}");
            Methods.Swap<int>(ref num1, ref num2);
            WriteLine("------------ After Swap-------------");
            WriteLine($"Num1 = {num1}");
            WriteLine($"Num2 = {num2}");
            #endregion
            #region Q5: Write a generic method FindMax<T> that finds maximum value
            WriteLine("========== FindMax method =================");
            int[] intArr = { 10,20,30,40,50};
            double[] douArr = { 1.5, 2, 3.5, 5.5, 10.10 };
           WriteLine( Methods.findMax(intArr));
           WriteLine( Methods.findMax(douArr));
            #endregion
            #region Q6: What is a generic interface? Write IRepository<T>. 
            //هو انترفيس يمكن لاي كلاس يامبلمينت منه ويحمل اي نوع سواء فاليو او ريفرانس
            IRepository<Container<int>> Iintcon;
            IRepository<Container<double>>Idoucon;
            #endregion

        }
    }
}
