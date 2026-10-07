using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        #region filds
        private string destinationCountry;
        private decimal customsFee;
        #endregion
        #region properties
        public string DestinationCountry
        {
            get
            {
                return this.destinationCountry;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("the DestinationCountry is null or empty");
                else
                    this.destinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return this.customsFee;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("the CustomsFee is less than zero");
                else
                    this.customsFee = value;
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + CustomsFee;
            }
        }
        #endregion
        #region constractor
        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee,default)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
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
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee}");
        }
        string ITrackable.GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is has been Delivered.";
        }
        decimal IInsurable.CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
        public virtual void GenerateCustomsReport() { }
        #endregion
    }
}
