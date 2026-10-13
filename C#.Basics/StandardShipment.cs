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

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
            destination.GetFullAddress();

        }
        string  ITrackable.GetTrackingStatus()
        {
            return TrackinCodeStutus=$"Shipment {TrackingCode} In Transit.";
        }
        decimal IInsurable.CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
        public override Shipment CopyShipment()
        {
            return new StandardShipment(this.TrackingCode, this.Description, this.Weight, this.DeliveryFee);
        }
        public override Shipment    ShallowCopy()
        {
            return (StandardShipment)this.MemberwiseClone();
        }
        public override Shipment DeepCopy()

        {
            DeliveryAddress nweAddress = new DeliveryAddress(this.Destination.BuildingNumber, this.Destination.Street, this.Destination.City);
            return new StandardShipment(this.TrackingCode, this.Description, this.Weight, this.DeliveryFee, nweAddress);
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
