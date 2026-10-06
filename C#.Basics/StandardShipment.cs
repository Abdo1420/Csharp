using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
            Console.WriteLine("-----------------------------");
        }
}   }
