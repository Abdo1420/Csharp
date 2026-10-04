
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            #region  What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //هيتغير في النسخة ومش هيتغير في المتغير الاصلي عشان ستراكت من نوع فاليو 
            #endregion

            #region What happens when a Customer variable is copied into another variable and one variable modifies the object
            //هيتم تغير قيمة الفاليو عند الاتنين لان الكلاس نوعه ريفرانس الاتنين ليهم نفس العنوان بيشاورو علي نفس المتغير
            #endregion
            #endregion

            #region Question 2
            #region a) Identify at least three problems with this design from an encapsulation perspective.
            //1-استخدام بابلك في كل الفيلد الي موجودة هيساعد علي الوصول ليها في اي مكان ومن اي كود وده ضد مبداء الانكبسوليشن
            //2- عدم وجود شرط لادخال البيانات ممكن يخلي مثلا ادخال قيم الوزن بالسالب لازم يكون في شروط لادخال البيانات بحيث مستقبلش اي بيانات عشوائية
            //3- البابلك مش هتسمحلي ان اعمل اي فيلد للقراءة فقد لان البابلك بتسمح للقراءة او تعديل اي متغير تم انشائه
            #endregion
            #region b) How can private fields and public properties improve this design? 
            //تحويلهم الي برايفت يمنع الوصول ليهم من اي كود اخر خارج الكلاس وده يحافظ علي سرية وصحة القيم المدخلة
            // البروبرتي هتفصل تعريف الداتا عن استخدمها بالجيت والسيت يعني ممكن اخلي الداتا للقراءة فقط ممكن اخليها للتغير القيم فقط وممكن اخليها الاتنين مع بعض
            #endregion
            #endregion

            #region Create one DeliveryAddress value, copy it into a second variable, modify the copy, and print both values to prove that the original did not change.
            DeliveryAddress deliveryAddress = new DeliveryAddress("Cairo", "arab", 14);
            DeliveryAddress deliveryAddress02 = deliveryAddress;
            deliveryAddress.GetFullAddress();
            deliveryAddress.GetFullAddress();
            deliveryAddress02.City = "alex";
            WriteLine(deliveryAddress.City);
            #endregion

            #region a. Create a DeliveryCenter
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            #endregion

            #region b)Read data for three shipments from the user.
            for (int i = 1; i <= 3; i++)
            {
                WriteLine($"Enter Ditels for {i} Shipment");
                WriteLine("Enter TrackingCode");
                string? trackingCode = ReadLine();
                WriteLine("Enter description");
                string? description = ReadLine();
                WriteLine("Enter Weight (kg)");
                decimal weight = 0;
                while (!decimal.TryParse(ReadLine(), out weight) || weight <= 0)
                {
                    WriteLine("Invalid input. Please enter a positive number for weight.");
                }
                WriteLine("Enter DeliveryFee");
                decimal deliveryFee = 0;
                while (!decimal.TryParse(ReadLine(), out deliveryFee) || deliveryFee < 0)
                {
                    WriteLine("Invalid input. Please enter a valid number for delivery fee.");
                }
                WriteLine("Enter Address Ditels");
                WriteLine("Enter buildingNumber");
                int buildingNumber = 0;
                while (!int.TryParse(ReadLine(), out buildingNumber) || buildingNumber <= 0)
                {
                    WriteLine("Invalid input. Please enter a positive number for building number.");
                }
                WriteLine("Enter Street");
                string? street = ReadLine();
                WriteLine("Enter City");
                string? city = ReadLine();
#endregion

            #region c)Create each Shipment and add it to the DeliveryCenter
                DeliveryAddress deliveryAddress1 = new DeliveryAddress(city, street, buildingNumber);
                Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, deliveryAddress1);
                bool isAdded = deliveryCenter.AddShipment(shipment);
                if (!isAdded)
                {
                    WriteLine("Failed to add shipment.");
                }
                else
                {
                    WriteLine("Shipment added successfully.");
                }
            }
                #endregion

            #region d) Print the three shipments using the integer indexer.
            for (int i = 0; i < 3; i++)
            {
                Shipment shipment = deliveryCenter[i];
                WriteLine($"Shipment {i + 1}:");
                WriteLine($"Tracking Code: {shipment.TrackingCode}");
                WriteLine($"Description: {shipment.Description}");
                WriteLine($"Weight: {shipment.Weight} kg");
                WriteLine($"Delivery Fee: {shipment.DeliveryFee}");
                WriteLine($"Delivery Address: {shipment.Description}");
            }
            #endregion

            #region e)Ask the user to enter a tracking code.
            WriteLine("Enter a tracking code to search: ");
            string? searchCode = ReadLine();
            #endregion

            #region f)Search for the shipment using the string indexer.
            Shipment? foundShipment = deliveryCenter[searchCode];
            #endregion

            #region g) Print the shipment if found; otherwise print:Shipment not found. 
            if (foundShipment.HasValue)
            {
                foundShipment.Value.PrintShipment();
            }
            else
            {
                WriteLine("Shipment not found.");
            }
            #endregion

            #region h)Demonstrate the DeliveryAddress struct copy behavior.
            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "El-Tahrir St", 10);
            DeliveryAddress addr2 = addr1;

            addr2.Street = "Makram Ebeid St";

            Console.WriteLine($"Original Address (addr1): Building {addr1.BuildingNumber}, {addr1.Street}, {addr1.City}");
            Console.WriteLine($"Copied & Modified (addr2): Building {addr2.BuildingNumber}, {addr2.Street}, {addr2.City}");
            //النتيجة هتكون ان العنوان الاصلي مش هيتغير لان الستركت من نوع فاليو والنسخة الي اتعملت اتغيرت بس مش العنوان الاصلي
            #endregion
        }

    }
}
