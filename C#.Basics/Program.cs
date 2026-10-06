
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            #region a)  What is the difference between Method Overloading and Method Overriding?
            //
            #endregion
            #region b)  What is the difference between Static Binding and Dynamic Binding?
            //
            #endregion
            #endregion

            #region Question 2
            #region a) What is the purpose of the sealed keyword when applied to a class?
            //
            #endregion
            #region b) What is the difference between a sealed class and a sealed method?
            //
            #endregion
            #region c)  Can a sealed method be overridden? Why?
            //
           
            #endregion
            

            #endregion

            #region 1.Create a DeliveryCenter.2.Read the center name from the user.
            WriteLine("Enter the name of the delivery center:");
            string? centerName = ReadLine();
            DeliveryCenter deliveryCenter = new DeliveryCenter(centerName);
            #endregion
            #region 3.Create one StandardShipment.4.Create one ExpressShipment.5.Create one InternationalShipment.
            Shipment? standardShipment= null;
            Shipment? expressShipment= null;
            Shipment?   internationalShipment= null;
            #endregion
            #region 6.Read all shipment data from the user.
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            WriteLine("Enter the tracking code for the standard shipment:");
                            string? trackingCode = ReadLine();
                            WriteLine("Enter the description for the standard shipment:");
                            string? description = ReadLine();
                            WriteLine("Enter the weight for the standard shipment:");
                            decimal weight = Convert.ToDecimal(ReadLine());
                            WriteLine("Enter the delivery fee for the standard shipment:");
                            decimal deliveryFee = Convert.ToDecimal(ReadLine());
                            WriteLine("Enter the destination for the standard shipment:");
                            WriteLine("Enter the building number:");
                            int buildingNumber = Convert.ToInt32(ReadLine());
                            WriteLine("Enter the street:");
                            string? street = ReadLine();
                            WriteLine("Enter the city:");
                            string? city = ReadLine();
                            DeliveryAddress destination = new DeliveryAddress(buildingNumber, street, city);
                            standardShipment= new StandardShipment(trackingCode, description, weight, deliveryFee, destination);
                            break;
                        }
                    case 1:
                        {
                            WriteLine("Enter the tracking code for the expressShipment shipment:");
                            string? trackingCode = ReadLine();
                            WriteLine("Enter the description for the expressShipment shipment:");
                            string? description = ReadLine();
                            WriteLine("Enter the weight for the expressShipment shipment:");
                            decimal weight = Convert.ToDecimal(ReadLine());
                            WriteLine("Enter the delivery fee for the expressShipment shipment:");
                            decimal deliveryFee = Convert.ToDecimal(ReadLine());
                            WriteLine("Enter the extra fee for the express shipment:");
                            decimal extraFee = Convert.ToDecimal(ReadLine());
                            WriteLine("Enter the destination for the expressShipment shipment:");
                            WriteLine("Enter the building number:");
                            int buildingNumber = Convert.ToInt32(ReadLine());
                            WriteLine("Enter the street:");
                            string? street = ReadLine();
                            WriteLine("Enter the city:");
                            string? city = ReadLine();
                            DeliveryAddress destination = new DeliveryAddress(buildingNumber, street, city);
                             expressShipment = new ExpressShipment(trackingCode, description, weight, deliveryFee, destination, extraFee);
                            break;
                        }
                    case 2:
                        {
                            WriteLine("Enter the tracking code for the internationalShipment shipment:");
                            string? trackingCode = ReadLine();
                            WriteLine("Enter the description for the internationalShipment shipment:");
                            string? description = ReadLine();
                            WriteLine("Enter the weight for the internationalShipment shipment:");
                            decimal weight = Convert.ToDecimal(ReadLine());
                            WriteLine("Enter the delivery fee for the internationalShipment shipment:");
                            decimal deliveryFee = Convert.ToDecimal(ReadLine());
                            WriteLine("Enter the destination country for the international shipment:");
                            string? destinationCountry = ReadLine();
                            WriteLine("enter the customs fee for the international shipment:");
                            decimal customsFee = Convert.ToDecimal(ReadLine());
                            WriteLine("Enter the destination for the internationalShipment shipment:");
                            WriteLine("Enter the building number:");
                            int buildingNumber = Convert.ToInt32(ReadLine());
                            WriteLine("Enter the street:");
                            string? street = ReadLine();
                            WriteLine("Enter the city:");
                            string? city = ReadLine();
                            DeliveryAddress destination = new DeliveryAddress(buildingNumber, street, city);
                             internationalShipment = new InternationalShipment(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee);
                            break;
                        }

                }
            }

            #endregion
            #region 7.Add the shipments to the delivery center.
            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);
            #endregion
            #region 8.Print all shipments.
            deliveryCenter.PrintAllShipments();
            #endregion
            #region 9.Search for a shipment using the existing tracking code indexer.
            WriteLine("Enter the trackingCode of the shipment you want to search for:");
            string? trackingCodeSearch = ReadLine();
            Shipment? shipment = deliveryCenter[trackingCodeSearch];
            #endregion
            #region 10.Remove one shipment using its tracking code.
            WriteLine("Enter the trackingCode for the shipment you want to remove:");
            string? trackingCodeToRemove = ReadLine();
            deliveryCenter.RemoveShipment(trackingCodeToRemove);
            #endregion
            #region 11.Print the remaining shipments.
            deliveryCenter.PrintAllShipments();
            #endregion
        }

    }
}
