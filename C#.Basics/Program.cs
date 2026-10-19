
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Object Copying
            #region a) What happens when you assign one object variable to another object variable?
            //The other variable will take on the same address as the first variable, and both will hold the same values.
            #endregion
            #region b) Does assigning one object to another create a new object? Explain.
            //No, it does not create a new object; instead, it takes a copy of the address of the first object. Consequently, it inherits all the values ​​held by that object, and any changes made to these values ​​will be reflected in both the first and the subsequent object.
            #endregion
            #region c) What is the difference between copying an object and copying its reference?
            //copying an object: It involves creating another object that is distinct from the first, yet holds the same values; any changes made to its values ​​will not be reflected in the original object.
            //copying its reference : It involves creating an object that holds the same address as the original object; consequently, any change to the values ​​of either one is reflected in the other.
            #endregion
            #endregion

            #region Q2  Shallow Copy vs Deep Copy
            #region a) What is a Shallow Copy?
            //It is a shallow copy of an object: for values ​​of a "value type," it creates a separate copy, whereas for "reference types," it copies the reference (the memory address). Consequently, any changes made to a value type remain isolated, while any changes made to a reference type will be reflected in the original object.
            #endregion
            #region b) What is a Deep Copy?
            //This involves creating a copy as an object that is entirely distinct from the original. Whether the original object contains value types or reference types, the new object receives completely independent copies of them; consequently, any change made to the values ​​in one object will not be reflected in the other.

            #endregion
            #region c) What happens to reference-type members when a Shallow Copy is created?
            //This copy will bear the same reference as the original object; consequently, any changes made to the copy will be reflected in the original object.

            #endregion
            #region d) What happens to reference-type members when a Deep Copy is created?
            //The object will take on a version distinct from the original; the values ​​will reside at entirely different memory addresses in each object, and any change made to the values ​​will not be reflected in the other object.
            #endregion

            #endregion

            #region Q3  Static Members
            #region a) What is a static field, and how is it different from an instance field?
            //static field : A member defined using the keyword "static" belongs exclusively to the class itself; individual objects cannot access or modify its value. It is shared across the entire class and can be invoked using the class name rather than through an object. 
            //instance field : This is a standard member, defined without any specific keywords. An object can interact with it and modify its value; when an object is created, it possesses its own independent member, which is accessed simply by using the object's name.

            #endregion
            #region b) What is a static method? Can a static method directly access instance members?
            //This is a method defined using the `static` keyword; it is invoked without an object—by using the class name itself—and cannot access instance members (which must also be `static`).

            #endregion
            #region c) What is a static constructor, and when is it executed?
            //It is a constructor created using the `static` keyword; it does not accept any parameters or access modifiers. It is designed to assign specific values ​​to static fields and is executed only once—either when an object is created or when any method within the class is called.

            #endregion
            #region d) What is a static class? Can you create an object from a static class?
            //This is a class created using the `static` keyword. It is a class from which no objects can be instantiated; all of its properties—including all fields and methods contained within it—must also be `static`. It does not permit the inclusion of any instance fields or instance methods.

            #endregion
            #endregion

            #region Q4  Extension Methods
            #region a) What is an Extension Method?
            //It is an additional function that can be added to a built-in class or a custom class that has already been defined; it is treated just like the functions that reside within the class itself.

            #endregion
            #region b) What keyword must be used in the first parameter of an extension method?
            //this It is the first word that must be written in the parameter, so that it becomes part of the class that follows this word.

            #endregion
            #region c) Where must an extension method be declared?
            //It can be declared in another class—for example, `StringExtension`—which should be a static class, and the function itself should also be static.

            #endregion
            #region d) Can an extension method access private members of the class it extends?
            //The class member cannot be accessed because its scope is limited to the class itself, and the method was defined outside of that class; therefore, it can only access inherited or public members.

            #endregion
            #endregion

            #region Q5  Partial Classes and Partial Methods
            #region a) What is a Partial Class?
            //A partial class is a class divided into two parts; each part is a class with the same name, preceded by the `partial` keyword, yet they function as a single, unified class.

            #endregion
            #region b) Why would a developer split one class into multiple files?
            //If we want to distribute the task of writing a class among the team, we can do so using "partial classes." This feature allows the team to work on the same class simultaneously. Alternatively, as the codebase grows, we can split a class into multiple files, with each file containing a specific portion of the code.

            #endregion
            #region c) What is a Partial Method?
            //It is a method defined in one part of a class that forces another part of the class to implement it.

            #endregion
            #region d) What happens if a declared partial method has no implementation?
            //A compile-time error will occur regarding the method signature.

            #endregion
            #endregion

            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle();
            DeliveryUtilities.PrintSeparator();

            #region Demonstrate reference assignment between two shipment variables
            Shipment? shipment01 = new StandardShipment("SH001", "laptop", 2, 80, new DeliveryAddress(123, "threr", "cairo"));
            Shipment sh = shipment01;

            #endregion
            #region Demonstrate that reference assignment does not create a new object
            Write("reference assignment does not create a new object : "); WriteLine(sh.Equals(shipment01));
            #endregion
            #region Create a Shallow Copy using MemberwiseClone().
            sh = shipment01.ShallowCopy();
            #endregion
            #region Demonstrate that the shallow copy shares the same DeliveryAddress
            DeliveryUtilities.PrintSeparator();
            WriteLine("Shallow Copy");
            DeliveryUtilities.PrintSeparator();
            WriteLine(shipment01.Destination.City);
            WriteLine(sh.Destination.City);
            sh.Destination.City = "Giza";
            WriteLine(shipment01.Destination.City);
            WriteLine(sh.Destination.City);
            #endregion
            #region Create a Deep Copy.
            sh = shipment01.DeepCopy();
            #endregion
            #region Demonstrate that the deep copy has an independent DeliveryAddress
            DeliveryUtilities.PrintSeparator();
            WriteLine("Deep Copy");
            DeliveryUtilities.PrintSeparator();
            WriteLine(shipment01.Destination.City);
            WriteLine(sh.Destination.City);
            sh.Destination.City = "porto";
            WriteLine(shipment01.Destination.City);
            WriteLine(sh.Destination.City);
            #endregion
            #region Add and demonstrate the static shipment counter.
            DeliveryUtilities.PrintSeparator();
            Shipment.TotalShipmentsCreated = 0;
            #endregion
            #region  a. Create one StandardShipment.
            StandardShipment? standardShipment = new StandardShipment("SH001", "laptop", 2, 80, new DeliveryAddress(123, "threr", "cairo"));
            #endregion
            #region b. Create one ExpressShipment.
            ExpressShipment? expressShipment = new ExpressShipment("SH002", "Mobile Phone", 2, 60, new DeliveryAddress(66, "arab", "sina"), 30);
            #endregion
            #region c. Create one InternationalShipment.
            InternationalShipment? internationalShipment = new InternationalShipment("Sh003", "Television", 8, 120, new DeliveryAddress(99, "bayrn", "munch"), "Germany", 100);
            #endregion
            #region Demonstrate the static constructor

            //يعمل الاستاتيك كونستراكتور في بداية تشغيل البرنامج يكتب رسالة توضح ذالك وهي (Shipment System Initialized)
            #endregion
            #region Call GetTotalShipmentsCreated().
            WriteLine( Shipment.GetTotalShipmentsCreated());
            #endregion
            #region Create and use DeliveryUtilities
            DeliveryUtilities.PrintSeparator();
            WriteLine("Useing DeliveryUtilities");
            DeliveryUtilities.PrintSeparator();
            #endregion
            #region Create and use ShipmentExtensions
            DeliveryUtilities.PrintSeparator();
            WriteLine("Using ShipmentExtensions");
            DeliveryUtilities.PrintSeparator();


            #endregion
            #region Demonstrate GetSummary().
            WriteLine( standardShipment.GetSummary());
            WriteLine( expressShipment.GetSummary());
            WriteLine( internationalShipment.GetSummary());
            #endregion
            #region Demonstrate IsDelivered().
           WriteLine( $"{standardShipment.TrackingCode} Is Delivered :{ standardShipment.IsDelivered()}");
           WriteLine( $"{internationalShipment.TrackingCode} Is Delivered :{internationalShipment.IsDelivered()}");
            #endregion
            #region Split Shipment into partial class files.
            DeliveryUtilities.PrintSeparator();
            WriteLine("Partial Method");
            DeliveryUtilities.PrintSeparator();
            #endregion
            #region Implement and demonstrate the partial method
            
            shipment01.OnTrackingStatusChanged("Delivered");
            #endregion
            DeliveryUtilities.PrintSeparator();
            WriteLine("Assignment Completed");
            DeliveryUtilities.PrintSeparator();
            #region Make sure all functionality from Assignment 04 still works

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

            #endregion

        }

    }
}
