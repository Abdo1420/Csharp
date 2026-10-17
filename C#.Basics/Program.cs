
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
            //Container<int> intCon = new Container<int>(1);
            //Container<double> doubleCon = new Container<double>(5.5);
            //Container<string> stringCon = new Container<string>("one");
            //intCon.Add(3);
            //WriteLine(intCon.Get());
            //doubleCon.Add(10.99);
            //WriteLine(doubleCon.Get());
            //stringCon.Add("anbdooo");
            //WriteLine(stringCon.Get());
            #endregion
            #region Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            //هو كلاس يقوم بانشاء اوبجيكت يحمل نوعين متشابهين او مختلفين من اي نوع داتا سواء ريفرانس او فاليو
            //WriteLine("========== Pair =================");
            //Pair<int, string> pair = new Pair<int, string>(1, "one");
            //WriteLine(pair.getFirst());
            //WriteLine(pair.getSocend());
            //WriteLine(pair.ToString());
            #endregion
            #region Q4: What is a generic method? Write Swap<T> method.
            //هي ميثود يمكنها ارجاع قيمة من اي نوع ويمكن استخدمها علي اي نوع فاليو سواء ريفرانس او فاليو
            //int num1 = 10;
            //int num2 = 5;
            //WriteLine("========== generic method =================");
            //WriteLine("  ");
            //WriteLine("========== Swap method =================");

            //WriteLine("------------ Before Swap-------------");
            //WriteLine($"Num1 = {num1}");
            //WriteLine($"Num2 = {num2}");
            //Methods.Swap<int>(ref num1, ref num2);
            //WriteLine("------------ After Swap-------------");
            //WriteLine($"Num1 = {num1}");
            //WriteLine($"Num2 = {num2}");
            #endregion
            #region Q5: Write a generic method FindMax<T> that finds maximum value
           // WriteLine("========== FindMax method =================");
           // int[] intArr = { 10,20,30,40,50};
           // double[] douArr = { 1.5, 2, 3.5, 5.5, 10.10 };
           //WriteLine( Methods.findMax(intArr));
           //WriteLine( Methods.findMax(douArr));
            #endregion
            #region Q6: What is a generic interface? Write IRepository<T>. 
            //هو انترفيس يمكن لاي كلاس يامبلمينت منه ويحمل اي نوع سواء فاليو او ريفرانس
            //IRepository<Container<int>> Iintcon;
            //IRepository<Container<double>>Idoucon;
            #endregion
            #region Q7: What is the 'struct' constraint? Write an example.
            WriteLine("========== 'struct' constraint =================");
            //تحديد نوع الكلاس بحيث لا يكون نوعه فاليو تايب فقط 
            //مثال كلاس كالكوليتور لا تحمل اي نوع غير الفاليو تايب
            //Calculetor<int> intcalc = new Calculetor<int>(55);
            //WriteLine(intcalc.getNumper());
            //Calculetor<double> doucalc = new Calculetor<double>(9.5);
            //WriteLine(doucalc.getNumper());
            //Calculetor<decimal> deccalc = new Calculetor<decimal>(9.9m);
            //WriteLine(deccalc.getNumper());
            #endregion
            #region Q8: What is the 'class' constraint? Write an example.
            //هو كلاس يقبل اي نوع من الريفرانس تايب ولا يقبل فاليو تايب
            //مثال علي كلاس كونتينر 
            //Container<string> strcon = new Container<string>("Contenac01");
            //Container<int> strcon = new Container<int>(2);//error becose int value type
            #endregion
            #region Q9: What is the 'new()' constraint? Write an example.
            // يحمل نوع كلاس الذي يقوم باايمبلمينت lessconstractor only
            //Exampel class animal genaric class and class cat  have lessconstractor but dog not have it
            //Cat cat = new Cat("cat");
            //Animals<Cat> myAnimal01 = new Animals<Cat>();//becose cat have lessconstractor
            //Dog dog = new Dog("dog");
            //Animals<Dog> myAnimal02 = new Animals<Dog>();//becose dog not have lessconstractor
            #endregion
            #region Q10:  What is the interface constraint? Write an example.
            //هو ان الكلاس لا يقبل نوع ريفرانس يجب يامبلميت من انترفيس معين 
            //exampel class animals and class cat and dog
            //Cat cat = new Cat("cat");
            //Animals<Cat> myAnimal01 = new Animals<Cat>();//becose cat not implment interface IComparable
            //Dog dog = new Dog("dog");
            //Animals<Dog> myAnimal02 = new Animals<Dog>();//becose dog implment interface IComparable 
            #endregion
            #region Q11: What is the base class constraint? Write an example.
            // نوع الكلاس لازن يانهاريت من base class اي نوع كلاس الي هنكتبه 
            //exampel class animals and class cat and dog
            //class Animals<T> T must inharet Zoo
            //Cat cat = new Cat("cat");
            //Animals<Cat> myAnimal01 = new Animals<Cat>();//becose cat  inharet class Zoo
            //Dog dog = new Dog("dog");
            //Animals<Dog> myAnimal02 = new Animals<Dog>();//becose dog not inharet class Zoo
            #endregion
            #region Q12: How do you apply multiple constraints? Write an example. 
            //يجب علي الكلاس ان يقبل نوع كلاس يقوم بعمل حاجتين معا مثال ان يرث من كلاس ويامبلمينت من انترفيس
            //example calss Animals and cat and dog
            //class Animals<T> T must inharet Class Zoo and implment interface IComparable
            //Cat cat = new Cat("cat");
            //Animals<Cat> myAnimal01 = new Animals<Cat>();//becose cat  inharet class Zoo only
            //Dog dog = new Dog("dog");
            //Animals<Dog> myAnimal02 = new Animals<Dog>();//becose dog  inharet class Zoo and implment interface IComparable
            #endregion

        } 
    }
}
