
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            #region a)  What is the difference between Method Overloading and Method Overriding?
            //overloading: هو تعريق ميثود بنفس الاسم ولاكن براميتر مختلف في العدد او الترتيب ويمكن تعريفها في نفس الكلاس 
            //overriding: هو تعريف ميثود بنفس الاسم ونفس البراميتر في كلاس فرعي ويجب ان تكون الميثود في الكلاس الاب virtual
            #endregion
            #region b)  What is the difference between Static Binding and Dynamic Binding?
            //static binding: هو ربط بين الميثود والكلاس في وقت كتابة الكود
            //dynamic binding: هو ربط بين الميثود والكلاس عند تشغلي البرنامج
            #endregion
            #endregion

            #region Question 2
            #region a) What is the purpose of the sealed keyword when applied to a class?
            //تجعل الكلاس لا يورث مرة اخري من قبل كلاس اخر فرعي 
            #endregion
            #region b) What is the difference between a sealed class and a sealed method?
            //sealed class: هو الكلاس الذي لا يمكن وراثته مرة اخري عبر كلاس فرعي عند استخدام الكاي ورد 
            //sealed method: هي الميثود الذي لا يمكن تعريفها في كلاس اخر
            #endregion
            #region c)  Can a sealed method be overridden? Why?
            //لا يمكن override للميثود المعلنة ب sealed لانها لا يمكن تعريفها في كلاس اخر

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
