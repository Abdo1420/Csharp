
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            #region a) What is the difference between a class and a struct?
            //storge: class s are reference types and are stored in the heap, while structs are value types and are stored in the stack.
            //inheritance: classes can inherit from other classes, while structs cannot inherit from other structs or classes.
            //default constructor: classes can have a default constructor, while structs cannot have a default constructor.
            //used for: classes are used for complex data types, while structs are used for simple data types.
            #endregion
            #region b) Why are classes more suitable than structs for large applications?
            //because classes are reference types and support inheritance, polymorphism, and encapsulation, which are all important features for large applications. Structs are value types and do not support these features, making them less suitable for large applications.
            #endregion
            #endregion

            #region Question 2
            #region a) Which class is the parent class?
            //class Shipment is the parent class.
            #endregion
            #region b) Which class is the child class?
            //class ExpressShipment is the child class.
            #endregion
            #region c) What members are inherited by ExpressShipment?
            //string TrackingCode;
            #endregion
            #region d) Why is inheritance better than duplicating the same code in multiple classes?
            //because inheritance allows for code reusability and reduces code duplication, making the code easier to maintain and less error-prone. Duplicating code in multiple classes can lead to inconsistencies and makes it harder to update or fix bugs in the code.
            #endregion

            #endregion


        }

    }
}
