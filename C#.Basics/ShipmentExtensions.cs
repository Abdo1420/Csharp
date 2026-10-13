using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            
            return $"Tracking Code: {shipment.TrackingCode}|Shipment Type: {shipment.GetType().Name}|Weight: {shipment.Weight}|Tracking Status: ";
        }
        public static bool IsDelivered(this Shipment shipment)
        {
            if(shipment is InternationalShipment)
            {
                return true;
            }
            return false;
        }
    }
}
