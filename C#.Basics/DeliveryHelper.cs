using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    static public class DeliveryHelper
    {
       static public void printShipmentDetails(Shipment shipment)
        {
            if(shipment == null)
            {
                Console.WriteLine("Shipment is null.");
                return;
            }
            shipment.PrintShipment();
            Console.WriteLine("Printing shipment details completed.");
        }
    }
}
