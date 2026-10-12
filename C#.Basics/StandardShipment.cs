using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        #region constractors
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee) : base(trackingCode, description, weight, deliveryFee, default)
        {
        }
        #endregion

        #region methods
        public override void PrintShipment()
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");

        }
        string  ITrackable.GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }
        decimal IInsurable.CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
        #endregion

        #region propyrts
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5);
            }
        }
        #endregion
    }
}   
