
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Object Copying
            #region a) What happens when you assign one object variable to another object variable?
            //سياخذ المتغير الاخر نفس عنوان المتغير الاول وسياخذ كل منهما نفس القيم.
            #endregion
            #region b) Does assigning one object to another create a new object? Explain.

            //لا لم يقوم بانشاء اوبجيكت جديد بل سياخذ نسخة من العنوان الخاص بالاوبجيكت الاول وبالتالي سياخذ كل القيم التي يحتفظ بها وعند عمل اي تغير في هذه القيم سوف يتغير في الاوبجيكت الاول والاخير معا
            #endregion
            #region c) What is the difference between copying an object and copying its reference?
            //copying an object: هو انشاء اوبجيكت اخر بعنوان منفصل عن الاول ولاكن يحمل نفس القيم واي تغير في القيم الخاصة به لن ينعكس التغير علي الاوبجيكت الاول
            //copying its reference : هو انشائ اوبجيكت يحمل نفس الهنوان الخاص بالاوبجيكت الاصل وبالتالي اي تغير في قيم اي واحد منهم ينعكس علي الاخر
            #endregion
            #endregion

            #region Q2  Shallow Copy vs Deep Copy
            #region a) What is a Shallow Copy?
            //هو نسخ سطحي للاوبجيكت اي ان القيم من النوع فاليو ياخذ منها نسخة منفصلة من الاوبجيكت الاصلي اما النوع ريفرانس ياخذ نسخة من العنوان الخاص بها اي ان التعيرات تحدث في الفاليو تياب واي تغير في القيم من النوع ريفرانس سوفت تنعكس علي الاوبجيكت الاول
            #endregion
            #region b) What is a Deep Copy?
            //هو اخذ نسخة باوبجيكت مختلف تماما عن الاوبجيكت الاصلي اي ان الاوبجيكت الاصل كان يحمل قيم فاليو تايب او ريفرانس تايب الاوبجيكت الاخر ياخذ منهم نسخ منفصلة تماما عنه اي ان اي تغير يحدث في القيم بينهم لن ينعكس علي الاوبيجكت الاخر

            #endregion
            #region c) What happens to reference-type members when a Shallow Copy is created?
            //ستحمل هذه النسخة نفس العنوان الذي يحمل الاوبجيكت الاصلي وبالتالي اي تغير في النسخة سينعكس علي الاوبجيكت الاصلي

            #endregion
            #region d) What happens to reference-type members when a Deep Copy is created?
            //سياخذ الاوبجيكت نسخة مختلفة عن الاوبجيكت الاصلي اي ان القيم ستكون في عناوين مختلفة تماما في كل اوبجيكت وعند حدوث اي تغير في القيم لن ينعكس علي الاوبجيكت الاخر
            #endregion

            #endregion

            #region Q3  Static Members
            #region a) What is a static field, and how is it different from an instance field?
            //static field : هو ميمبر يتم تعرفيه عن طريق كتابة كلمة استاتيك وهو يكون مخصص للكلاس فقط لامكن للاوبجيكت ان يتعامل معه او ياغير في قيمته وهو مشترك في الكلاس ككل ويمكن استدعائه من خلال اسم الكلاس وليس بواسطة اوبجيكت 
            //instance field : هو ميمبر عادي يتم تعرفيه بدون كاي ورد معينة ويمكن للاوبجيكت التعامل معه والتغير في قيمته عند انشاء اي اوبجيكت يحمل كل اوبجيكت ميبر مستقل خاص به ويتم استدعائه عن طريق اسم الاوبجيكت فقط

            #endregion
            #region b) What is a static method? Can a static method directly access instance members?
            //هي ميثود يتم تعرفيها عن طريق الكاي ورد ستاتيك ويتم استدعائها بدون اوبجيكت عن طريق اسم الكلاس نفسه ولا يمكن استخدام انستانس ميبمبر يجب ان يكون ستاتيك ايضا

            #endregion
            #region c) What is a static constructor, and when is it executed?
            //هو كونستراكتور يتم انشائه عن طريق الكاي ورد ستاتيك ولا ياخذ براميتار او اكسيس موديفاير ويتم انشائه ليقوم بتعين القيم التي نريدها للاستاتيك فيلدز ويتم تنفيذه لمرة واحدة فقط عند انشائ اوبجيكت او استدعاء اي ميثود داخل الكلاس

            #endregion
            #region d) What is a static class? Can you create an object from a static class?
            //هو كلاس يتم انشائه عن طريق كاي ورد ستاتيك وهو كلاس لايمكن انشاء اي اوبجيكت منه ويجب ان تكون كل خصائصه ستاتيك وكل ما بداخله من فيلدز او ميثودس ستاتيك ايضا لا يقبل ان يكون بداخله انستانس فيلظز او ميثود

            #endregion
            #endregion

            #region Q4  Extension Methods
            #region a) What is an Extension Method?
            //هي دالة اضافية متاح اضافتها في كلاس بيلد ان او كلاس عادي تمت كتابته بالفعل وتعامل معاملة الدوالي التي داخل الكلاس عادي

            #endregion
            #region b) What keyword must be used in the first parameter of an extension method?
            //this هي اول كلمة يجب ان تكتب في الباميتار لكي تكون من ضمن الكلاس التي سياتي بعد هذه الكلمة

            #endregion
            #region c) Where must an extension method be declared?
            //يمكن الاعلان عنها في كلاس اخر علي سبيل المثال stringExtension ويكون ستاتيك كلاس وتكون هذه الدالة ستاتيك ايضا

            #endregion
            #region d) Can an extension method access private members of the class it extends?
            //لا يمكن الوصول الي الميبر الخاص بالكلاس لان حدودها داخل الكلاس فقط والمثود تم انائه خارج الكلاس نفسه اذا يمكنه الوصول الي الميمبر المورثة او البابلك

            #endregion
            #endregion

            #region Q5  Partial Classes and Partial Methods
            #region a) What is a Partial Class?
            //البرتشال كلاس هو كلاس مقسوم الي قسمين وكل جزء يكون كلاس يحمل نفس الاسم ويكون قبله الكاي ورد partial ولاكن يعمل في جزء واحد

            #endregion
            #region b) Why would a developer split one class into multiple files?
            //لانه اذا اردنا تقسيم كتابة الكلاس علي التيم يمككنا فعل ذالك عن طريق برتشال كلاس بهذه الميزة يمكن للتيم استخدام الكلاس في وقت واحد او عند كبر حجم الكود يمكننا تقسيم الكلاس الي فايلز وكل فايلز تحمل جزء معين من الكود

            #endregion
            #region c) What is a Partial Method?
            //هي ميثود يتم انشائها في جزء من الكلاس يجبر الجزء الاخر علي عمل امبلمنتيشن للهذه الميثود

            #endregion
            #region d) What happens if a declared partial method has no implementation?
            //سيحدث ايرور في الكومبايل تيام عن سيجنتشر الميثود

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
