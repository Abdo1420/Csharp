
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            #region a)  What is Abstraction in Object-Oriented Programming?
            //هو تجريد البروبرتي او الميثود من التفاصيل المعقدة واظهار اسمها فقط وماذا تعمل اي تجريدها من الامبلمنتيشن

            #endregion
            #region b) Why is abstraction considered one of the four pillars of OOP?
            //لانه يخفي التفاصيل الكثيرة والمعقدة ويسهل التعامل مع الكود المعقد ويسهل عملية التحديث في اي جزء في الكود

            #endregion
            #endregion

            #region Question 2
            #region a)  What is the difference between an Abstract Class and an Interface?
            //
            #endregion
            #region b)  When would you choose an Interface instead of an Abstract Class?

            //

            #endregion
            #region c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            //

            #endregion


            #endregion

            #region  a. Create one StandardShipment.
            StandardShipment? standardShipment = new StandardShipment("SH001", "laptop", 2, 80);

            #endregion
            #region b. Create one ExpressShipment.
            ExpressShipment? expressShipment = new ExpressShipment("SH002", "Mobile Phone", 2, 60, 30);
            #endregion
            #region c. Create one InternationalShipment.
            InternationalShipment? internationalShipment = new InternationalShipment("Sh003", "Television", 8,120, "Germany",100);
            #endregion

            #region  d. Add all shipments to the DeliveryCenter.
            DeliveryCenter deliveryCenter = new DeliveryCenter("Route");
            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);
            #endregion
            #region  e. Print all shipment details.
            deliveryCenter.PrintCenterInfo();
            deliveryCenter.PrintAllShipments();
            #endregion
        }

    }
}
