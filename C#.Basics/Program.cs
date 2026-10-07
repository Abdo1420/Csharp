
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            #region What is Abstraction in Object-Oriented Programming?
            //هو تجريد البروبرتي او الميثود من التفاصيل المعقدة واظهار اسمها فقط وماذا تعمل اي تجريدها من الامبلمنتيشن
            #endregion
            #region Why is abstraction considered one of the four pillars of OOP?
            //لانه يخفي التفاصيل الكثيرة والمعقدة ويسهل التعامل مع الكود المعقد ويسهل عملية التحديث في اي جزء في الكود
            #endregion
            #endregion

            #region Question 2
            #region a)  What is the difference between an Abstract Class and an Interface?
            // 
            #endregion
            #region b) When would you choose an Interface instead of an Abstract Class?
            //
            #endregion
            #region c) Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // 

            #endregion


            #endregion

            #region 1.Create a Driver.
            Driver driver = new Driver("Ahmed Mohamed");

            #endregion
            #region 2.Create a DeliveryCenter.
            DeliveryCenter deliveryCenter = new DeliveryCenter("Delivery Center");
            #endregion
            #region 3.Assign the Driver to the DeliveryCenter.
            driver.AssignedCenter = deliveryCenter;
            
            #endregion
            #region 4.Create one StandardShipment.
            Shipment? standardShipment = new StandardShipment("SH001", "laptop", 2, 80);
            #endregion
            #region 5.Create one ExpressShipment.

            Shipment? expressShipment = new ExpressShipment("SH002", "Mobile Phone", 2, 60, 30);
            #endregion
            #region 6.Create one InternationalShipment.
            Shipment? internationalShipment = new InternationalShipment("Sh003", "Television", 8,120, "Germany",100);
            #endregion
            #region 7.Add all shipments to the DeliveryCenter.
            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);
            #endregion
            #region 8.Print all shipments.
            
           deliveryCenter.PrintCenterInfo();
            WriteLine($"Driver Name: {driver.Name}");
            deliveryCenter.PrintAllShipments();
            #endregion
            #region 9.Call DeliveryHelper.PrintShipmentDetails() for each shipment.
            WriteLine("\n==========================================\nPrinting Using DeliveryHelper");
            DeliveryHelper.printShipmentDetails(standardShipment);
            DeliveryHelper.printShipmentDetails(expressShipment);
            DeliveryHelper.printShipmentDetails(internationalShipment);
            #endregion
            #region 10.Updating Weight
            WriteLine("\n==========================================");
            WriteLine($"Original Weight : {standardShipment.Weight}");
            standardShipment.UpdateWeight(5);
            WriteLine($"Updated Weight : {standardShipment.Weight}");
            standardShipment.UpdateWeight(0.5, true);
            WriteLine($"Updated Weight After Packing : {standardShipment.Weight}");

            #endregion
            #region 11.Build a Shipment[] holding mixed types and print all of them in a loop.
            WriteLine("\n==========================================\nPrinting Using Shipment Array");
            Shipment[] shipments =  { standardShipment, expressShipment, internationalShipment };
            foreach (Shipment s in shipments)
            {
                s.PrintShipment();
            }
            #endregion
            #region 12.Demonstrate the sealed class and sealed method (comments or code).
            //sealed calss:هو الكلاس الذي لا يمكن وراثته مرة اخري عبر كلاس فرعي عند استخدام الكاي ورد 
            //sealed method: هي الميثود الذي لا يمكن تعريفها في كلاس اخر
            #endregion

        }
    }
}
