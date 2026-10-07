
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
            //apstract class:ممكن يحتوي علي ميثود عادية وميوثد ابستراكت
            //interface: يحتوي علي ميثود ابستراكت فقط
            //عشان كدا الانترفيس اكثر تكامل لمبداء الابستراكشن 
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
            #region f. Print the tracking status of every shipment.
            ITrackable trackableShipment = standardShipment;
            WriteLine("---------------------------------------");
            WriteLine("Tracking Status of Standard Shipment:");
            WriteLine(trackableShipment.GetTrackingStatus());
            trackableShipment = expressShipment;
            WriteLine("---------------------------------------");
            WriteLine("Tracking Status of Express Shipment:");
            WriteLine(trackableShipment.GetTrackingStatus());
            trackableShipment = internationalShipment;
            WriteLine("---------------------------------------");
            WriteLine("Tracking Status of International Shipment:");
            WriteLine(trackableShipment.GetTrackingStatus());
            #endregion
            #region g. Print the insurance cost of every shipment.
            IInsurable insurableShipment = standardShipment;
            WriteLine("---------------------------------------");
            WriteLine("Insurance Cost of Standard Shipment:");
            WriteLine(insurableShipment.CalculateInsurance());
            insurableShipment = expressShipment;
            WriteLine("---------------------------------------");
            WriteLine("Insurance Cost of Express Shipment:");
            WriteLine(insurableShipment.CalculateInsurance());
            insurableShipment = internationalShipment;
            WriteLine("---------------------------------------");
            WriteLine("Insurance Cost of International Shipment:");
            WriteLine(insurableShipment.CalculateInsurance());
            #endregion
            #region h. Store the shipment objects in an ITrackable[] array and print their tracking statuses.

            ITrackable[] trackableShipments = { standardShipment, expressShipment, internationalShipment };
            WriteLine("---------------------------------------");
            WriteLine("Tracking Statuses of All Shipments:");
            foreach (ITrackable shipment in trackableShipments)
            {
                WriteLine(shipment.GetTrackingStatus());
            }
            #endregion
            #region i. Store the shipment objects in an IInsurable[] array and print their insurance values.
            IInsurable[] insurableShipments = { standardShipment, expressShipment, internationalShipment };
            WriteLine("---------------------------------------");
            WriteLine("Insurance Values of All Shipments:");
            foreach (IInsurable shipment in insurableShipments)
            {
                WriteLine(shipment.CalculateInsurance());
            }
            #endregion
        }

    }
}
