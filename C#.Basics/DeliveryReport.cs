using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public class DeliveryReport
    {
       public static void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine($"Shipment Status: {shipment.GetTrackingStatus()}");
        }
       public static void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance Cost: ${shipment.CalculateInsurance()}");
        }
    }
}
