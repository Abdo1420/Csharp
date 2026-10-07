using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;
        #region proprtis
        public decimal ExtraFee { get; set; }=0;
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
            }
        }

        #endregion
        #region constractor
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, decimal extraFee) : base(trackingCode, description, weight, deliveryFee,default)
        {
            ExtraFee = extraFee;
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
            Console.WriteLine($"Extra Fee: {ExtraFee}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
        }
        string ITrackable.GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }
        decimal IInsurable.CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
        #endregion
    }
}
